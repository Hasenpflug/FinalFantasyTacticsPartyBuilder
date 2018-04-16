var JobOverview = function ()
{
    var piemenu, modifierChartCanvas, modifierChart, growthChartCanvas, growthChart, baseMoveJumpChartCanvas, baseMoveJumpChart, baseEvasionChartCanvas, baseEvasionChart,
        selectedJobData, selectedUnitPosition, isMobile, navigator;

    $(document).ready(function ()
    {
        navigator = $('#navigator-previous');
        navigator.hide();
        isMobile = window.innerWidth < 600;

        if (typeof (Storage) !== 'undefined')
        {
            var unitDataRaw = getUnitData();
            if (unitDataRaw === null)
            {
                localStorage.setItem('unitData', '{"units": []}')
            }

            renderUnitPanels();
        }

        navigator.click(renderUnitPanels);
        $('body').on('click', '.item-details-button', renderItemDetailsPartial);
        $('body').on('click', '#item-details-close', function () { $('#item-details-container').remove(); })
        $('body').on('click', '.new-unit-selector', renderJobOverviewPanel);
        $('body').on('click', '.unit-container[data-unit-position]', renderUnitStatusPanel);
        $('body').on('click', '#gender-male-button, #gender-female-button', updateJobWheel);
        $('body').on('click', '#job-confirm-button', hireUnit);
        $('body').on('click', '#menu-unit-remove', renderDismissUnitPartial);
        $('body').on('click', '#dismiss-cancel', function () { $('#unit-dismiss-container').remove(); });
        $('body').on('click', '#dismiss-unit', dismissUnit);
        $('body').on('click', '#menu-unit-item, #menu-unit-ability ', renderUnitStatsDetailsPartial);
        $('body').on('click', '#menu-unit-cancel', function () { $('.unit-details-container').toggle(); $('.menu-container').toggle(); });
        $('body').on('click', '.equipment-selector', renderItemLookupPartial);
        $('body').on('click', '.item-category', renderItemSelectionPartial);
        $('body').on('mouseover', '.item-names', previewEquipmentChanges);
        $('body').on('mouseleave', '.item-names', resetItemStats);
    });

    function renderUnitPanels()
    {
        var unitData = buildPanelData(getUnitData());
        $.post('/Home/GetUnitPanelPartial', unitData, function (data)
        {
            navigator.hide();
            $('#party-overview-container').contents().remove();
            $('#party-overview-container').prepend(data);
        });
    }

    function renderUnitStatusPanel(event)
    {
        if (selectedUnitPosition === event.currentTarget.attributes['data-unit-position'].nodeValue)
        {
            $('.unit-details-container').toggle();
            $('.menu-container').toggle();
        }
        else
        {
            selectedUnitPosition = event.currentTarget.attributes['data-unit-position'].nodeValue;
            var unitData = getUnitData();

            unitData = unitData.units[selectedUnitPosition];

            $.post('/Home/GetUnitOverviewPartial', unitData, function (data)
            {
                $('.unit-details-container').remove();
                $('#party-overview-container').append(data);
                if (isMobile)
                {
                    if (event.pageY > window.innerHeight / 1.5)
                    {
                        $('.unit-details-container').css({
                            top: '10%'
                        });
                    }
                }

                renderMenuPanel(event, selectedUnitPosition);
            });
        }
    }

    function renderMenuPanel(event, unitPosition)
    {
        $.post('/Home/GetUnitMenuPartial', unitPosition, function (data)
        {
            $('.menu-container').remove();
            $('#party-builder-container').append(data);

            if (!isMobile)
            {
                var windowScrollOffset = (document.getElementsByClassName('body-content')[0].scrollTop / window.innerHeight) * 100;
                var convertedUnitPosition = parseInt(unitPosition) + 1;
                var columnIndex = (convertedUnitPosition % 4 === 0 && convertedUnitPosition !== 0 ? 0.40 : ((parseInt(unitPosition) % 4) / 4)) * 100 + 20;
                var rowIndex = Math.trunc(parseInt(unitPosition) / 4) * 30 + 10 - windowScrollOffset;

                $('.menu-container').css({
                    left: columnIndex + '%',
                    top: rowIndex + '%'
                });
            }
        });
    }

    function renderJobOverviewPanel()
    {
        $.post('/Home/GetJobOverviewPartial', function (data)
        {
            navigator.show();
            $('#party-overview-container').contents().remove();
            $('#party-overview-container').append(data);
            selectedUnitPosition = '-1';
            renderJobSelectionPanel('Male');
        });
    }

    function renderJobSelectionPanel(gender)
    {
        $.post('/Home/GetJobSelectionPartial', { gender: gender }, function (data)
        {
            $('#job-selection-container').remove();
            $('#job-overview-container').prepend(data);
            initializeJobWheel();
            initializeJobModifierChart();
            initializeJobGrowthChart();
            initializeJobMoveChart();
            initializeJobEvasionChart();
        });
    }

    function renderUnitStatsDetailsPartial()
    {
        var unitData = getUnitData();
        unitData = unitData.units[selectedUnitPosition];
        selectedJobData = unitData;

        $.post('/Home/GetUnitStatsDetailPartial', { unit: unitData }, function (data)
        {
            navigator.show();
            $('#party-overview-container').contents().remove();
            $('#party-overview-container').append(data);
            selectedUnitPosition = '-1';
        });
    }

    function renderItemLookupPartial(event)
    {
        var equipmentCategoryID = event.currentTarget.attributes['data-equipment-category'].nodeValue;

        $.post('/Home/GetUnitItemLookupPartial', {
            jobID: selectedJobData.Unit.JobID, equipmentCategoryID: equipmentCategoryID,
            isFemale: selectedJobData.Unit.Gender === 1 ? true : false
        }, function (data)
        {
            $('#item-lookup-container').remove();
            $('#item-selection').remove();
            $('#unit-abilities').append(data);
        });
    }

    function renderItemDetailsPartial(event)
    {
        var itemID = event.currentTarget.attributes['data-item-id'].nodeValue;

        $.post('/Home/GetItemDetailsPartial', { itemID }, function (data)
        {
            $('#party-overview-container').append(data);
        });
    }

    function renderItemSelectionPartial(event)
    {
        var itemCategory = event.currentTarget.attributes['data-item-category'].nodeValue;

        $.post('/Home/GetItemSelectionPartial', { itemCategoryID: itemCategory }, function (data)
        {
            $('#item-selection').remove();
            $('#item-lookup-container').append(data);
        });
    }

    function previewEquipmentChanges(event)
    {
        var itemCategoryName = event.currentTarget.attributes['data-item-category-name'].nodeValue;

        switch (itemCategoryName)
        {
            case "weapon":
                var rightDamageElement = document.querySelector('#weapon-stats-right-damage');
                var rightHitElement = document.querySelector('#weapon-stats-right-hit');
                var rightEquippedElement = document.querySelector('#weapon-equipped').firstElementChild;
                var rightHit = rightEquippedElement !== null ? parseInt(rightEquippedElement.attributes['data-item-hit-percentage'].nodeValue) : 0;
                var rightDamage = rightEquippedElement !== null ? parseInt(rightEquippedElement.attributes['data-item-power'].nodeValue) : 0;
                var itemDamage = parseInt(event.currentTarget.attributes['data-item-power'].nodeValue);
                var itemHit = parseInt(event.currentTarget.attributes['data-item-hit-percentage'].nodeValue);

                if (itemDamage > rightDamage)
                {
                    rightDamageElement.firstChild.textContent = '+' + (itemDamage - rightDamage);
                    rightDamageElement.firstChild.style.color = 'blue';

                }
                else if (itemDamage < rightDamage)
                {
                    rightDamageElement.firstChild.textContent = '-' + (rightDamage - itemDamage);
                    rightDamageElement.firstChild.style.color = 'red';
                }

                if (itemHit > rightHit)
                {
                    rightHitElement.firstChild.textContent = '+' + (itemHit - rightHit);
                    rightHitElement.firstChild.style.color = 'blue';
                }
                else if (itemHit < rightHit)
                {
                    rightHitElement.firstChild.textContent = '-' + (rightHit - itemHit);
                    rightHitElement.firstChild.style.color = 'red';
                }

                previewSpeedDamageChanges(event.currentTarget, rightEquippedElement);
                break;
            case "shield":
                var leftPhysicalEvadeElement = document.querySelector('#shield-stats-physical-evade');
                var leftMagicalEvadeElement = document.querySelector('#shield-stats-magical-evade');
                var leftEquippedElement = document.querySelector('#shield-equipped').firstElementChild;
                var physicalEvade = leftEquippedElement !== null ? parseInt(leftEquippedElement.attributes['data-item-physical-evade'].nodeValue) : 0;
                var magicalEvade = leftEquippedElement !== null ? parseInt(leftEquippedElement.attributes['data-item-magical-evade'].nodeValue) : 0;
                var itemPhysicalEvade = parseInt(event.currentTarget.attributes['data-item-physical-evade'].nodeValue);
                var itemMagicalEvade = parseInt(event.currentTarget.attributes['data-item-magical-evade'].nodeValue);

                if (itemPhysicalEvade > physicalEvade)
                {
                    leftPhysicalEvadeElement.firstChild.textContent = '+' + (itemPhysicalEvade - physicalEvade);
                    leftPhysicalEvadeElement.firstChild.style.color = 'blue';
                }
                else if (itemPhysicalEvade < physicalEvade)
                {
                    leftPhysicalEvadeElement.firstChild.textContent = '-' + (physicalEvade - itemPhysicalEvade);
                    leftPhysicalEvadeElement.firstChild.style.color = 'red';
                }

                if (itemMagicalEvade > magicalEvade)
                {
                    leftMagicalEvadeElement.firstChild.textContent = '+' + (itemMagicalEvade - magicalEvade);
                    leftMagicalEvadeElement.firstChild.style.color = 'blue';
                }
                else if (itemMagicalEvade < magicalEvade)
                {
                    leftMagicalEvadeElement.firstChild.textContent = '-' + (magicalEvade - itemMagicalEvade);
                    leftMagicalEvadeElement.firstChild.style.color = 'red';
                }

                previewSpeedDamageChanges(event.currentTarget, leftEquippedElement);
                break;
            case "helmet":
                var hpBonusElement = document.querySelector('#armour-stats-hp-bonus');
                var mpBonusElement = document.querySelector('#armour-stats-mp-bonus');
                var headEquippedElement = document.querySelector('#head-equipped').firstElementChild;
                var hpBonus = headEquippedElement != null ? parseInt(headEquippedElement.attributes['data-item-helmet-hp-bonus'].nodeValue) : 0;
                var mpBonus = headEquippedElement != null ? parseInt(headEquippedElement.attributes['data-item-helmet-mp-bonus'].nodeValue) : 0;
                var itemHpBonus = parseInt(event.currentTarget.attributes['data-item-hp'].nodeValue);
                var itemMpBonus = parseInt(event.currentTarget.attributes['data-item-mp'].nodeValue);

                if (itemHpBonus > hpBonus)
                {
                    hpBonusElement.textContent = '+' + (itemHpBonus - hpBonus);
                    hpBonusElement.style.color = 'lightblue';
                    hpBonusElement.style.visibility = 'visible';
                }
                else if (itemHpBonus < hpBonus)
                {
                    hpBonusElement.textContent = '-' + (hpBonus - itemHpBonus);
                    hpBonusElement.style.color = 'red';
                    hpBonusElement.style.visibility = 'visible';
                }

                if (itemMpBonus > mpBonus)
                {
                    mpBonusElement.textContent = '+' + (itemMpBonus - mpBonus);
                    mpBonusElement.style.color = 'lightblue';
                    mpBonusElement.style.visibility = 'visible';
                }
                else if (itemMpBonus < mpBonus)
                {
                    mpBonusElement.textContent = '-' + (mpBonus - itemMpBonus);
                    mpBonusElement.style.color = 'red';
                    mpBonusElement.style.visibility = 'visible';
                }

                previewSpeedDamageChanges(event.currentTarget, headEquippedElement);
                break;
            case "armor":
                var hpBonusElement = document.querySelector('#armour-stats-hp-bonus');
                var mpBonusElement = document.querySelector('#armour-stats-mp-bonus');
                var armorEquippedElement = document.querySelector('#body-equipped').firstElementChild;
                var hpBonus = armorEquippedElement != null ? parseInt(armorEquippedElement.attributes['data-item-body-hp-bonus'].nodeValue) : 0;
                var mpBonus = armorEquippedElement != null ? parseInt(armorEquippedElement.attributes['data-item-body-mp-bonus'].nodeValue) : 0;
                var itemHpBonus = parseInt(event.currentTarget.attributes['data-item-hp'].nodeValue);
                var itemMpBonus = parseInt(event.currentTarget.attributes['data-item-mp'].nodeValue);

                if (itemHpBonus > hpBonus)
                {
                    hpBonusElement.textContent = '+' + (itemHpBonus - hpBonus);
                    hpBonusElement.style.color = 'lightblue';
                    hpBonusElement.style.visibility = 'visible';
                }
                else if (itemHpBonus < hpBonus)
                {
                    hpBonusElement.textContent = '-' + (hpBonus - itemHpBonus);
                    hpBonusElement.style.color = 'red';
                    hpBonusElement.style.visibility = 'visible';
                }

                if (itemMpBonus > mpBonus)
                {
                    mpBonusElement.textContent = '+' + (itemMpBonus - mpBonus);
                    mpBonusElement.style.color = 'lightblue';
                    mpBonusElement.style.visibility = 'visible';
                }
                else if (itemMpBonus < mpBonus)
                {
                    mpBonusElement.textContent = '-' + (mpBonus - itemMpBonus);
                    mpBonusElement.style.color = 'red';
                    mpBonusElement.style.visibility = 'visible';
                }

                previewSpeedDamageChanges(event.currentTarget, armorEquippedElement);
                break;
            case "shoe":
                var moveElement = document.querySelector('#move-stat-value');
                var jumpElement = document.querySelector('#jump-stat-value');
                var accessoryEquippedElement = document.querySelector('#accessory-equipped').firstElementChild;
                var moveBonus = accessoryEquippedElement != null ? parseInt(accessoryEquippedElement.attributes['data-item-move-bonus'].nodeValue) : 0;
                var jumpBonus = accessoryEquippedElement != null ? parseInt(accessoryEquippedElement.attributes['data-item-jump-bonus'].nodeValue) : 0;
                var itemMoveBonus = parseInt(event.currentTarget.attributes['data-item-move-bonus'].nodeValue);
                var itemJumpBonus = parseInt(event.currentTarget.attributes['data-item-jump-bonus'].nodeValue);

                if (itemMoveBonus > moveBonus)
                {
                    moveElement.firstChild.textContent = '+' + (itemMoveBonus - moveBonus);
                    moveElement.firstChild.style.color = 'blue';
                    moveElement.firstChild.style.visibility = 'visible';
                }
                else if (itemMoveBonus < moveBonus)
                {
                    moveElement.firstChild.textContent = '-' + (moveBonus - itemMoveBonus);
                    moveElement.firstChild.style.color = 'red';
                    moveElement.firstChild.style.visibility = 'visible';
                }

                if (itemJumpBonus > jumpBonus)
                {
                    jumpElement.firstChild.textContent = '+' + (itemJumpBonus - jumpBonus);
                    jumpElement.firstChild.style.color = 'blue';
                    jumpElement.firstChild.style.visibility = 'visible';
                }
                else if (itemJumpBonus < jumpBonus)
                {
                    jumpElement.firstChild.textContent = '-' + (jumpBonus - itemJumpBonus);
                    jumpElement.firstChild.style.color = 'red';
                    jumpElement.firstChild.style.visibility = 'visible';
                }

                previewSpeedDamageChanges(event.currentTarget, accessoryEquippedElement);
                break;
            case "armguard":
                var accessoryEquippedElement = document.querySelector('#accessory-equipped').firstElementChild;
                var currentItem = event.currentTarget;                
                previewSpeedDamageChanges(currentItem, accessoryEquippedElement);
                break;
            case "ring":
                var accessoryEquippedElement = document.querySelector('#accessory-equipped').firstElementChild;
                var currentItem = event.currentTarget;
                previewSpeedDamageChanges(currentItem, accessoryEquippedElement);
                break;
            case "cloak":
                var physicalEvadeElement = document.querySelector('#accessory-physical-evade');
                var magicalEvadeElement = document.querySelector('#accessory-magical-evade');
                var accessoryEquippedElement = document.querySelector('#accessory-equipped').firstElementChild;
                var equippedPhysicalEvade = accessoryEquippedElement != null ? parseInt(accessoryEquippedElement.attributes['data-item-physical-evade'].nodeValue) : 0;
                var equippedMagicalEvade = accessoryEquippedElement != null ? parseInt(accessoryEquippedElement.attributes['data-item-magical-evade'].nodeValue) : 0;
                var itemPhysicalEvadeBonus = parseInt(event.currentTarget.attributes['data-item-physical-evade'].nodeValue);
                var itemMagicalEvadeBonus = parseInt(event.currentTarget.attributes['data-item-magical-evade'].nodeValue);

                if (itemPhysicalEvadeBonus > equippedPhysicalEvade)
                {
                    physicalEvadeElement.firstChild.textContent = '+' + (itemPhysicalEvadeBonus - equippedPhysicalEvade);
                    physicalEvadeElement.firstChild.style.color = 'blue';
                    physicalEvadeElement.firstChild.style.visibility = 'visible';
                }
                else if (itemPhysicalEvadeBonus < equippedPhysicalEvade)
                {
                    physicalEvadeElement.firstChild.textContent = '-' + (equippedPhysicalEvade - itemPhysicalEvadeBonus);
                    physicalEvadeElement.firstChild.style.color = 'red';
                    physicalEvadeElement.firstChild.style.visibility = 'visible';
                }

                if (itemMagicalEvadeBonus > equippedMagicalEvade)
                {
                    magicalEvadeElement.firstChild.textContent = '+' + (itemMagicalEvadeBonus - equippedMagicalEvade);
                    magicalEvadeElement.firstChild.style.color = 'blue';
                    magicalEvadeElement.firstChild.style.visibility = 'visible';
                }
                else if (itemMagicalEvadeBonus < equippedMagicalEvade)
                {
                    magicalEvadeElement.firstChild.textContent = '-' + (equippedMagicalEvade - itemMagicalEvadeBonus);
                    magicalEvadeElement.firstChild.style.color = 'red';
                    magicalEvadeElement.firstChild.style.visibility = 'visible';
                }

                previewSpeedDamageChanges(event.currentTarget, accessoryEquippedElement);
                break;
            case "bracelet":
                var accessoryEquippedElement = document.querySelector('#accessory-equipped').firstElementChild;
                var currentItem = event.currentTarget;
                previewSpeedDamageChanges(currentItem, accessoryEquippedElement);
                break;
        }

        function previewSpeedDamageChanges(itemElement, equippedElement)
        {
            var physicalAttackBonus = 0, magicalAttackBonus = 0, speedBonus = 0, itemPhysicalAttackBonus = 0, itemMagicalAttackBonus = 0, itemSpeedBonus = 0;
            var physicalAttackElement = document.querySelector('#physical-attack-power');
            var magicalAttackElement = document.querySelector('#magical-attack-power');
            var speedElement = document.querySelector('#speed-stat-value');
            if (equippedElement != null)
            {
                physicalAttackBonus = equippedElement.attributes['data-item-physical-bonus'] != null ?
                    parseInt(equippedElement.attributes['data-item-physical-bonus'].nodeValue) : 0;
                magicalAttackBonus = equippedElement.attributes['data-item-magical-bonus'] != null ?
                    parseInt(equippedElement.attributes['data-item-magical-bonus'].nodeValue) : 0;
                speedBonus = equippedElement.attributes['data-item-speed-bonus'] != null ?
                    parseInt(equippedElement.attributes['data-item-speed-bonus'].nodeValue) : 0;
            }

            if (itemElement != null)
            {            
                itemPhysicalAttackBonus = itemElement.attributes['data-item-physical-bonus'] != null ?
                    parseInt(itemElement.attributes['data-item-physical-bonus'].nodeValue) : 0;
                itemMagicalAttackBonus = itemElement.attributes['data-item-magical-bonus'] != null ?
                    parseInt(itemElement.attributes['data-item-magical-bonus'].nodeValue) : 0;
                itemSpeedBonus = itemElement.attributes['data-item-speed-bonus'] != null ?
                    parseInt(itemElement.attributes['data-item-speed-bonus'].nodeValue) : 0;
            }

            if (itemPhysicalAttackBonus > physicalAttackBonus)
            {
                physicalAttackElement.firstChild.textContent = '+' + (itemPhysicalAttackBonus - physicalAttackBonus);
                physicalAttackElement.firstChild.style.color = 'blue';
                physicalAttackElement.firstChild.style.visibility = 'visible';
            }
            else if (itemPhysicalAttackBonus < physicalAttackBonus)
            {
                physicalAttackElement.firstChild.textContent = '-' + (physicalAttackBonus - itemPhysicalAttackBonus);
                physicalAttackElement.firstChild.style.color = 'red';
                physicalAttackElement.firstChild.style.visibility = 'visible';
            }

            if (itemMagicalAttackBonus > magicalAttackBonus)
            {
                magicalAttackElement.firstChild.textContent = '+' + (itemMagicalAttackBonus - magicalAttackBonus);
                magicalAttackElement.firstChild.style.color = 'blue';
                magicalAttackElement.firstChild.style.visibility = 'visible';
            }
            else if (itemMagicalAttackBonus < magicalAttackBonus)
            {
                magicalAttackElement.firstChild.textContent = '-' + (magicalAttackBonus - itemMagicalAttackBonus);
                magicalAttackElement.firstChild.style.color = 'red';
                magicalAttackElement.firstChild.style.visibility = 'visible';
            }

            if (itemSpeedBonus > speedBonus)
            {
                speedElement.firstElementChild.textContent = '+' + (itemSpeedBonus - speedBonus);
                speedElement.firstElementChild.style.color = 'blue';
                speedElement.firstElementChild.style.visibility = 'visible';
            }
            else if (itemSpeedBonus < speedBonus)
            {
                speedElement.firstChild.textContent = '-' + (speedBonus - itemSpeedBonus);
                speedElement.firstChild.style.color = 'red';
                speedElement.firstChild.style.visibility = 'visible';
            }
        }
    }

    function resetItemStats(event)
    {
        var rightDamageElement = document.querySelector('#weapon-stats-right-damage');
        var rightHitElement = document.querySelector('#weapon-stats-right-hit');
        var leftPhysicalEvadeElement = document.querySelector('#shield-stats-physical-evade');
        var leftMagicalEvadeElement = document.querySelector('#shield-stats-magical-evade');
        var hpBonusElement = document.querySelector('#armour-stats-hp-bonus');
        var mpBonusElement = document.querySelector('#armour-stats-mp-bonus');
        var moveElement = document.querySelector('#move-stat-value');
        var jumpElement = document.querySelector('#jump-stat-value');
        var physicalAttackElement = document.querySelector('#physical-attack-power');
        var magicalAttackElement = document.querySelector('#magical-attack-power');
        var speedElement = document.querySelector('#speed-stat-value');
        var accessoryPhysicalEvadeElement = document.querySelector('#accessory-physical-evade');
        var accessoryMagicalEvadeElement = document.querySelector('#accessory-magical-evade');


        rightDamageElement.firstChild.textContent = rightDamageElement.attributes['data-item-power'].nodeValue;
        rightDamageElement.firstChild.style.color = '#333333';
        rightHitElement.firstChild.textContent = rightHitElement.attributes['data-item-hit'].nodeValue;
        rightHitElement.firstChild.style.color = '#333333';

        leftPhysicalEvadeElement.firstChild.textContent = leftPhysicalEvadeElement.attributes['data-item-physical-evade'].nodeValue;
        leftPhysicalEvadeElement.firstChild.style.color = '#333333';
        leftMagicalEvadeElement.firstChild.textContent = leftMagicalEvadeElement.attributes['data-item-magical-evade'].nodeValue;
        leftMagicalEvadeElement.firstChild.style.color = '#333333';

        hpBonusElement.style.visibility = 'hidden';
        mpBonusElement.style.visibility = 'hidden';

        moveElement.firstChild.textContent = moveElement.attributes['data-item-default-move'].nodeValue;
        moveElement.firstChild.style.color = '#333333';
        jumpElement.firstChild.textContent = jumpElement.attributes['data-item-default-jump'].nodeValue;
        jumpElement.firstChild.style.color = '#333333';

        physicalAttackElement.firstChild.textContent = physicalAttackElement.attributes['data-item-power'].nodeValue;
        physicalAttackElement.firstChild.style.color = '#333333';
        magicalAttackElement.firstChild.textContent = magicalAttackElement.attributes['data-item-power'].nodeValue;
        magicalAttackElement.firstChild.style.color = '#333333';
        speedElement.firstChild.textContent = speedElement.attributes['data-item-default-speed'].nodeValue;
        speedElement.firstChild.style.color = '#333333';

        accessoryPhysicalEvadeElement.firstElementChild.textContent = accessoryPhysicalEvadeElement.attributes['data-item-physical-evade'].nodeValue;
        accessoryPhysicalEvadeElement.firstElementChild.style.color = '#333333';
        accessoryMagicalEvadeElement.firstElementChild.textContent = accessoryMagicalEvadeElement.attributes['data-item-magical-evade'].nodeValue;
        accessoryMagicalEvadeElement.firstElementChild.style.color = '#333333';
    }

    function renderDismissUnitPartial()
    {
        var localUnitData = getUnitData();
        localUnitData = localUnitData.units[selectedUnitPosition];
        var viewModelData = {
            Position: parseInt(selectedUnitPosition),
            UnitName: localUnitData.Unit.UnitName,
            Gender: parseInt(localUnitData.Unit.Gender),
            GenderName: localUnitData.Unit.GenderName,
            JobName: localUnitData.Unit.JobName
        };

        $.post('/Home/GetUnitDismissPartial', viewModelData, function (data)
        {
            $('#unit-dismiss-container').remove();
            $('#party-builder-container').append(data);
        });
    }

    function getUnitData()
    {
        return JSON.parse(localStorage.getItem('unitData'));
    }

    function hireUnit()
    {
        var localUnitData = getUnitData();
        var newUnitData = new UnitDetails();
        newUnitData.Unit.JobID = selectedJobData.jobID;
        newUnitData.Unit.Gender = selectedJobData.gender;
        newUnitData.Unit.Position = localUnitData.units.length;
        $.post('/Home/PopulateNewUnitData', { jobID: newUnitData.Unit.JobID, gender: newUnitData.Unit.Gender, position: newUnitData.Unit.Position }, function (data)
        {
            $('#party-overview-container').contents().remove();
            localUnitData.units.push(data);
            localStorage.setItem('unitData', JSON.stringify(localUnitData));
            renderUnitPanels();
        });
    }

    function dismissUnit()
    {
        var unitData = getUnitData();
        unitData.units.splice(selectedUnitPosition, 1);
        localStorage.setItem('unitData', JSON.stringify(unitData));
        $('#party-overview-container').contents().remove();
        selectedUnitPosition = '-1';
        renderUnitPanels();
    }

    function buildPanelData(unitData)
    {
        var unitDataLength = unitData.units.length;
        var unitPanelData = { units: [] };
        for (var i = 0; i < unitDataLength; i++)
        {
            unitPanelData.units.push({
                JobID: unitData.units[i].Unit.JobID, JobName: unitData.units[i].Unit.JobName, MaxHP: unitData.units[i].Unit.MaxHP, MaxMP: unitData.units[i].Unit.MaxMP,
                Position: unitData.units[i].Unit.Position, Gender: unitData.units[i].Unit.GenderName
            });
        }

        return unitPanelData;
    }

    function updateChartData(chart, jobData)
    {
        selectedJobData = jobData;
        document.getElementById('job-name').innerHTML = selectedJobData.name;
        modifierChart.data.datasets[0].data = [parseInt(selectedJobData.hpm), parseInt(selectedJobData.mpm), parseInt(selectedJobData.spm), parseInt(selectedJobData.pam),
        parseInt(selectedJobData.mam)];
        growthChart.data.datasets[0].data = [parseInt(selectedJobData.hpc), parseInt(selectedJobData.mpc), parseInt(selectedJobData.spc), parseInt(selectedJobData.pac),
        parseInt(selectedJobData.mac)];
        baseMoveJumpChart.data.datasets[0].data = [parseInt(selectedJobData.move), parseInt(selectedJobData.jump)];
        baseEvasionChart.data.datasets[0].data = [parseInt(selectedJobData.evasion)];
        modifierChart.update();
        growthChart.update();
        baseMoveJumpChart.update();
        baseEvasionChart.update();
    }

    function initializeJobWheel()
    {
        if (window.innerWidth > 600)
        {
            piemenu = new wheelnav('piemenu');
            piemenu.centerX = window.innerWidth / 2 - window.innerWidth / 20;
            piemenu.centerY = window.innerHeight / 2 - window.innerHeight / 20;
            piemenu.selectedPercent = 1.1;
            piemenu.hoverPercent = 1;
            piemenu.clockwise = false;
            piemenu.animatetime = 200;
            piemenu.maxPercent = 0.50;
            piemenu.animateeffect = 'linear';
            piemenu.createWheel();
        }
        else
        {
            piemenu = new wheelnav('piemenu');
            piemenu.centerY = window.innerHeight / 12;
            piemenu.selectedPercent = 1.1;
            piemenu.hoverPercent = 1;
            piemenu.clockwise = false;
            piemenu.animatetime = 200;
            piemenu.maxPercent = 2.5;
            piemenu.animateeffect = 'linear';
            piemenu.createWheel();
        }
    }

    function setInitialJobData(jobData)
    {
        selectedJobData = jobData;
    }

    function updateJobWheel(event)
    {
        if (piemenu !== 'undefined')
        {
            piemenu.removeWheel();
        }

        var gender = event.currentTarget.attributes['data-gender'].nodeValue;
        renderJobSelectionPanel(gender);
        if (gender === 'Male')
        {
            document.getElementById('gender-male-button').setAttribute('selected', true);
            document.getElementById('gender-female-button').setAttribute('selected', false);
        }
        else
        {
            document.getElementById('gender-male-button').setAttribute('selected', false);
            document.getElementById('gender-female-button').setAttribute('selected', true);
        }
    }

    function initializeJobModifierChart()
    {
        modifierChartCanvas = document.getElementById('job-modifier-chart');
        modifierChart = new Chart(modifierChartCanvas, {
            type: 'radar',
            data: {
                labels: ["HPM", "MPM", "SPM", "PAM", "MAM"],
                datasets: [{
                    label: 'Job Stat Modifiers',
                    data: [100, 75, 100, 90, 80],
                    borderColor: 'rgba(255, 0, 0, 0.5)',
                    backgroundColor: 'rgba(255, 0, 0, 0.34)',
                    pointBackgroundColor: 'white',
                    pointBorderColor: 'yellow',
                    defaultFontFamily: 'Altima',
                    defaultFontSize: '30'
                }]
            },
            options: {
                maintainAspectRatio: false,
                scale: {
                    ticks: {
                        suggestedMin: 40,
                        suggestedMax: 160,
                        stepSize: 10,
                        display: false
                    },
                    pointLabels: {
                        fontSize: window.innerWidth > 600 ? 60 : 30,
                        fontFamily: 'Altima'
                    }
                },
                legend: false
            }
        });

        modifierChart.resize();
    }

    function initializeJobGrowthChart(data)
    {
        growthChartCanvas = document.getElementById('job-growth-chart');
        growthChart = new Chart(growthChartCanvas, {
            type: 'radar',
            data: {
                labels: ["HPC", "MPC", "SPC", "PAC", "MAC"],
                datasets: [{
                    label: 'Job Stat Constants',
                    data: [75, 76, 80, 68, 80],
                    borderColor: 'rgba(255, 0, 0, 0.5)',
                    backgroundColor: 'rgba(255, 0, 0, 0.34)',
                    pointBackgroundColor: 'white',
                    pointBorderColor: 'yellow',
                    defaultFontFamily: 'Altima',
                    defaultFontSize: '60'
                }]
            },
            options: {
                maintainAspectRatio: false,
                scale: {
                    ticks: {
                        suggestedMin: 0,
                        suggestedMax: 100,
                        stepSize: 10,
                        display: false
                    },
                    pointLabels: {
                        fontSize: window.innerWidth > 600 ? 60 : 30,
                        fontFamily: 'Altima'
                    }
                },
                legend: false,
            }
        });

        growthChart.resize();
    }

    function initializeJobMoveChart(data)
    {
        baseMoveJumpChartCanvas = document.getElementById('job-move-chart');
        baseMoveJumpChart = new Chart(baseMoveJumpChartCanvas, {
            type: 'bar',
            data: {
                labels: ["Move", "Jump"],
                datasets: [{
                    label: 'Job Move Attributes',
                    data: [4, 3],
                    backgroundColor: 'rgba(255, 0, 0, 0.34)'
                }]
            },
            options: {
                maintainAspectRatio: false,
                scales: {
                    yAxes: [{
                        ticks: {
                            min: 0,
                            max: 5,
                        }
                    }],
                    xAxes: [{
                        ticks: {
                            fontSize: window.innerWidth > 600 ? 40 : 30,
                            fontFamily: 'Altima'
                        }
                    }]
                },
                legend: false
            }
        });

        baseMoveJumpChart.resize();
    }

    function initializeJobEvasionChart()
    {
        baseEvasionChartCanvas = document.getElementById('job-evasion-chart');
        baseEvasionChart = new Chart(baseEvasionChartCanvas, {
            type: 'bar',
            data: {
                labels: ["Evasion"],
                datasets: [{
                    label: 'Job Base Evasion',
                    data: [5],
                    backgroundColor: 'rgba(255, 0, 0, 0.34)'
                }]
            },
            options: {
                maintainAspectRatio: false,
                scales: {
                    yAxes: [{
                        ticks: {
                            min: 0,
                            max: 40,
                        }
                    }],
                    xAxes: [{
                        ticks: {
                            fontSize: window.innerWidth > 600 ? 40 : 30,
                            fontFamily: 'Altima'
                        }
                    }]
                },
                legend: false
            }
        });

        baseEvasionChart.resize();
    }

    function getModifierChart()
    {
        return modifierChart;
    }

    function UnitDetails()
    {
        this.RawHP = 0,
            this.RawMP = 0,
            this.RawSpeedGrowth = 0,
            this.RawPhysicalAttack = 0,
            this.RawMagicalAttack = 0,
            this.SecondaryAbilityJobID = 1,
            this.ReactionAbilityID = 1,
            this.SupportAbilityID = 1,
            this.MovementAbilityID = 1,
            this.WeaponID = 1,
            this.Unit = {
                UnitID: 0,
                UnitName: '',
                Position: 0,
                Gender: 0,
                GenderName: "Male",
                JobID: 1,
                JobName: 'Squire',
                JobPortraitPath: '',
                MaxHP: 0,
                MaxMP: 0,
                Level: 1,
                Experience: 0,
                Brave: 0,
                Faith: 0
            },
            this.ShieldID = 1,
            this.HeadID = 1,
            this.BodyID = 1,
            this.AccessoryID = 1
    }

    return {
        getModifierChart: getModifierChart,
        initializeJobWheel: initializeJobWheel,
        setInitialJobData: setInitialJobData,
        initializeJobModifierChart: initializeJobModifierChart,
        initializeJobGrowthChart: initializeJobGrowthChart,
        initializeJobMoveChart: initializeJobMoveChart,
        initializeJobEvasionChart: initializeJobEvasionChart,
        updateChartData: updateChartData
    }

}();