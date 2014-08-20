// JavaScript Functions

/*
function sayHello(name, greeting) {
	if (typeof name === 'undefined')  {
		return;
	};
	if (typeof greeting === 'undefined') {
		greeting = 'Hello';
	};
	console.log(greeting +  " World! " + name);

	return name.length;
}

console.log(sayHello("Omar", "Greetings"));

console.log(sayHello('Jim'));

console.log(sayHello());
*/



/*

var color = 'black';
var number = 1;

function showColor() {
	var color = 'green';
	shape = "square";
	number = 2;
	console.log('showColor color', color);
	console.log('showColor number', number);
	console.log('showColor shape', shape);
}

showColor();

console.log('Global color', color);
console.log('Global number', number);
console.log('showColor shape', shape);

 */





/*



var myFunction = function () {
	console.log('My function was called');
	undeclaredVariable;
}

var callTwice = function (targetFunction) {
	targetFunction();
	targetFunction();
}

callTwice(function () {
	console.log('Hello from the anonymous function');
});


(function () {
	var a, b, c;
	//...
	console.log('from anon function:was');
})(1, 'hello');



*/



//Examples

var button = document.getElementById('action');
var input = document.getElementById('text_field');


button.addEventListener('click', function () {
	console.log('clicked!');
})

button.addEventListener('click', function () {
	console.log('Other clicked!');
	input.setAttribute('value', 'Hello world');
})






























