(function ($) {
	"use strict"


	/* function draw() {
		
	} */

	var dzSparkLine = function () {
		let draw = Chart.controllers.line.__super__.draw; //draw shadow

		var screenWidth = $(window).width();


		var areaChart3 = function () {
			//gradient area chart
			if (jQuery('#areaChart_3').length > 0) {
				const areaChart_3 = document.getElementById("areaChart_3").getContext('2d');

				areaChart_3.height = 100;

				new Chart(areaChart_3, {
					type: 'line',
					data: {
						defaultFontFamily: 'Poppins',
						labels: ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16","17", "18", "19", "20", "21", "22", "23", "24"],
						datasets: [
							{
								label: "Sınav Notu",
								data: [25, 20, 60, 41, 66, 45, 80, 54, 20, 60, 41, 66, 45, 80, 20, 60, 41, 66, 45, 80,20, 60, 41, 66, 45],
								borderColor: 'rgb(235, 129, 83)',
								borderWidth: "1",
								backgroundColor: 'rgba(235, 129, 83, .5)'
							},
							//{
							//	label: "Sınav Notu",
							//	data: [15, 40, 30, 71, 36, 85, 30, 24, 90, 100, 21, 46, 65, 20, 70, 10, 81, 36, 75, 20, 60, 35, 76, 36, 25],
							//	borderColor: 'rgb(255, 92, 0)',
							//	borderWidth: "1",
							//	backgroundColor: 'rgba(255, 92, 0, .5)'
							//}
						]
					},
					options: {
						legend: false,
						scales: {
							yAxes: [{
								ticks: {
									beginAtZero: true,
									max: 100,
									min: 0,
									stepSize: 20,
									padding: 10
								}
							}],
							xAxes: [{
								ticks: {
									padding: 5
								}
							}]
						}
					}
				});
			}
		}


		/* Function ============ */
		return {
			init: function () {
			},


			load: function () {
				areaChart3();
			},

			resize: function () {
				// barChart1();	
				// barChart2();
				// barChart3();	
				// lineChart1();	
				// lineChart2();		
				// lineChart3();
				// lineChart03();
				// areaChart1();
				// areaChart2();
				// areaChart3();
				// radarChart();
				// pieChart();
				// doughnutChart(); 
				// polarChart(); 
			}
		}

	}();



	jQuery(window).on('load', function () {
		dzSparkLine.load();
	});

	jQuery(window).on('resize', function () {
		//dzSparkLine.resize();
		setTimeout(function () { dzSparkLine.resize(); }, 1000);
	});

})(jQuery);