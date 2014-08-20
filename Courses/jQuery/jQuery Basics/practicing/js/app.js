//Problem: Use when clicking on image goes to a dead end
//Solution: Create an overlay with the large image - Lightbox


$overlay = $('<div id="overlay"></div>');
$image = $("<img>");
$caption = $('<p></p>');

$overlay.append($image);
$overlay.append($caption);
$("body").append($overlay);


$("#imageGallery a").click(function(event) {
  event.preventDefault()

  var $imageLocation = $(this).attr("href"); 
  var $captionText = $(this).children("img").attr("alt");

  $image.attr("src", $imageLocation);
  $caption.text($captionText);

  $overlay.show();
})


$overlay.click(function() {
  $overlay.hide();
});