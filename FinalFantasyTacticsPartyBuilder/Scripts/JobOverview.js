var JobOverview = function ()
{
    var piemenu, modifierChartCanvas, modifierChart, growthChartCanvas, growthChart, baseMoveJumpChartCanvas, baseMoveJumpChart, baseEvasionChartCanvas, baseEvasionChart,
        selectedJobData, selectedUnitPosition;

    $(document).ready(function ()
    {
        if (typeof (Storage) !== 'undefined')
        {
            renderUnitPanels();
        }
    });

    $('body').on('click', '.new-unit-selector', renderJobOverviewPanel);
    $('body').on('click', '.unit-container[data-unit-position]', renderUnitStatusPanel);
    $('body').on('click', '#gender-male-button, #gender-female-button', updateJobWheel);
    $('body').on('click', '#job-confirm-button', hireUnit);

    function renderUnitPanels()
    {
        var unitDataRaw = localStorage.getItem('unitData');
        if (unitDataRaw === null)
        {
            localStorage.setItem('unitData', '{"units": []}')
        }

        var unitData = buildPanelData(JSON.parse(localStorage.getItem('unitData')));
        $.post('/Home/GetUnitPanelPartial', unitData, function (data)
        {
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
            var unitData = JSON.parse(localStorage.getItem('unitData'));

            unitData = unitData.units[selectedUnitPosition];

            $.post('/Home/GetUnitOverviewPartial', unitData, function (data)
            {
                $('.unit-details-container').remove();
                $('#party-overview-container').append(data);
                if (event.pageY > window.innerHeight / 1.5)
                {
                    $('.unit-details-container').css({
                        top: '10%'
                    });
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
            var convertedUnitPosition = parseInt(unitPosition) + 1;
            var columnIndex = (convertedUnitPosition % 4 === 0 && convertedUnitPosition !== 0 ? 0.40 : ((parseInt(unitPosition) % 4) / 4)) * 100 + 20;
            var rowIndex = Math.trunc(parseInt(unitPosition) / 4) * 30 + 10;

            $('.menu-container').css({
                left: columnIndex + '%',
                top: rowIndex + '%'
            });
        });
    }

    function renderJobOverviewPanel()
    {
        $.post('/Home/GetJobOverviewPartial', function (data)
        {
            $('#party-overview-container').contents().remove();
            $('#party-overview-container').append(data);
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

    function hireUnit()
    {
        var localUnitData = JSON.parse(localStorage.getItem('unitData'));
        var newUnitData = new Unit();
        newUnitData.jobID = selectedJobData.jobID;
        newUnitData.gender = selectedJobData.gender;
        $.post('/Home/PopulateNewUnitData', newUnitData, function (data)
        {
            $('#party-overview-container').contents().remove();
            localUnitData.units.push(data);
            localStorage.setItem('unitData', JSON.stringify(localUnitData));
            renderUnitPanels();
        });
    }

    function dismissUnit()
    {

    }

    function buildPanelData(unitData)
    {
        var unitDataLength = unitData.units.length;
        var unitPanelData = {units: []};
        for (var i = 0; i < unitDataLength; i++) {
            unitPanelData.units.push({
                JobID: unitData.units[i].Unit.JobID, JobName: unitData.units[i].Unit.JobName, RawHP: unitData.units[i].RawHP, RawMP: unitData.units[i].RawMP,
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
        piemenu = new wheelnav('piemenu');
        piemenu.centerX = window.innerWidth / 2 - 50;
        piemenu.centerY = window.innerHeight / 3;
        piemenu.selectedPercent = 1.1;
        piemenu.hoverPercent = 1;
        piemenu.clockwise = false;
        piemenu.animatetime = 200;
        piemenu.maxPercent = 0.50;
        piemenu.animateeffect = 'linear';
        piemenu.createWheel();
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
        modifierChartCanvas.wid
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
                    defaultFontSize: '60'
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
                        fontSize: 60,
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
                        fontSize: 60,
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
                scales: {
                    yAxes: [{
                        ticks: {
                            min: 0,
                            max: 5,
                        }
                    }],
                    xAxes: [{
                        ticks: {
                            fontSize: 40,
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
                scales: {
                    yAxes: [{
                        ticks: {
                            min: 0,
                            max: 40,
                        }
                    }],
                    xAxes: [{
                        ticks: {
                            fontSize: 40,
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

    function Unit()
    {
        this.name = '',
            this.maxhp = 0,
            this.maxmp = 0,
            this.gender = 0,
            this.position = 0,
            this.jobID = 1,
            this.jobName = '',
            this.hpc = 0,
            this.mpc = 0,
            this.spc = 0,
            this.pac = 0,
            this.mac = 0,
            this.secondaryJobID = 1,
            this.reactionID = 1
        this.supportID = 1,
        this.movementID = 1,
        this.weaponID = 1,
        this.shieldID = 1,
        this.headID = 1,
        this.bodyID = 1,
        this.accessoryID = 1,
        this.level = 1,
        this.experience = 0,
        this.brave = 0,
        this.faith = 0
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