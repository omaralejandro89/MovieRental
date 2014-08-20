

$(function() {
	 /*	$("#draggables").children().draggable(); */
	 $("#d1").draggable( { axis: "x" } );

	 $("#d2").draggable({
	  snap: "#d1, #d3",
	  helper: function() {
	  	return $("<div>I am a helper!</div>")
	  } });

	 $("#d3").draggable({ 
	 	containment: "#draggables",
	 	handle: "header" }); 

	 $("#d1, #d2, #d3").draggable(
		"option", "stack", ".ui.draggable-")
})