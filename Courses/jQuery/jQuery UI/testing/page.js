$(function() {	
	$("#dialog").dialog({
		autoOpen: false,
		modal: true,
		resizable: false,
		draggable: false,
		position: "top"
	});
	$("#openDialog").click(function() {
		$("#dialog").dialog("open");
		
	})


	$("#progress").progressbar({ value: 100 });

	var value = 100;

	countdown();

	function countdown() {
		value--;
		$("#progress").progressbar("option", "value", value);
		$("#countdown").text(value);

		if (value > 0) {
			setTimeout(countdown, 100);
		}
		else {
			$("#countdown").text("completed");
			$("#progress").progressbar("disable");
		}
	}

	$("#slider-test").slider( { min: 0, max: 100, value: 100, slide: function(event, ui) {
		$("#slider-test").prev().css({ opacity: ui.value/100 });
	} });
	
	
	$("#tabs-testing").tabs();

/* Check again */
	$("#accordian").accordion({ autoHeight: false, collapsible: true,
		change: function (event, ui) {
			console.log(event);
			console.log(ui);
			console.log("hi!");
		}
	 });
/*
	$("#accordian").accordion("activate", true);
/* Finish Check again */

	var $classes = [
		"C#",
		"HTML",
		"CSS",
		"jQuery",
		"JavaScript"
	];

	$("#search").autocomplete({
		source: $classes
	});

	$("#buttons").children()
				 .button({ icons: { primary: "ui-icon-search", secondary: "ui-icon-wrench"} })
				 .click(function() {
				 	alert($(this).val());
				 });

	$("#radios").buttonset();
	$("#checks").buttonset();

	$("#dateselection").datepicker({
		showAnim: "bounce",
		showWeek: true
	  });

	$("#dateselection").datepicker("setDate", new Date(2014, 10-1, 11));


});