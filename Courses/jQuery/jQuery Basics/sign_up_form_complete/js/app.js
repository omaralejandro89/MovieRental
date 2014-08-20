//Problem: Hints are shown even when form is valid
//Solution: Hide and show them at appropriate times

//Hide hints
$("form span").hide();

var $password = $("#password")
var $confirmPassword = $("#confirm_password");

function isPasswordValid () {
  return $password.val().length > 8;
}

function arePasswordsMatching () {
  return $password.val() === $confirmPassword.val()
}

function canSubmit () {
  return isPasswordValid() && arePasswordsMatching();
}



function passwordEvent() {
  if (isPasswordValid())  {

    //hide if it is valid
    $password.next().hide();
  } else {
    // else show hint
    $password.next().show();
    }
}


function confirmPasswordEvent () {
  //find out if password and confirmation match
  if (arePasswordsMatching()) {
    //hide hint if match
    $confirmPassword.next().hide();
  } else {
    //else show hint
    $confirmPassword.next().show();
  }
}

function enableSubmitEvent() {
  $("#submit").prop("disabled", !canSubmit());

}


//When event happens on password input
$password.focus(passwordEvent).keyup(passwordEvent).keyup(confirmPasswordEvent).keyup(enableSubmitEvent);



//WHen event happens on confirmation
$confirmPassword.focus(confirmPasswordEvent).keyup(confirmPasswordEvent).keyup(enableSubmitEvent);

enableSubmitEvent();








