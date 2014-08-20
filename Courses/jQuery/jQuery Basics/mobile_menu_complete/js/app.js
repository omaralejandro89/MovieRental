//Problem: It look gross in smaller browser widths and small devices
//Solution: To hide the text links and swap them out with a more appropriate navigation

// Create a select append #menu
var $select = $("<select></select>");
$("#menu").append($select);
// Cycle over menu links
$("#menu a").each(function() {
  var $anchor = $(this);
  //Create an option
  var $option = $("<option></option>");

  // Deal with selected options depending current page
  if ($anchor.parent().hasClass("selected")) {
    $option.prop("selected", true);
  }

  // option's value is the href
  $option.val($anchor.attr("href"));
  // option's text is the text of the link
  $option.text($anchor.text());
  // append option to select
  $select.append($option);


})
  

// Bind change listener to the select
$select.change(function () {
  //go to slect's location
  window.location = $select.val(); 
})
  
  



  
// Modify CSS to hode links on small width and show button and select
  //Also hides select and button on larger width and show's links





