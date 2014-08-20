//JavaScript Numbers

var a = 11,
    b = -123;
    
var c = 1.25,
    d = 123.456789;
    
var e= 0.1;
    f = 0.2;
    
var result = e*f;

var g = 1.23E6;

var h = 012; //octal number


//parseInt and parseFloat are functions to get a number out of a string
var j = parseInt("019", 10);  //taking a number out of a sctring
var k = parseInt("010111", 8);
var l = parseInt("There are 23 people", 10);
//console.log(isNaN(l));

var m = parseFloat("0123.456 is a strange number");

//Operators

var o = 1 + 2;
var p = 10 - 7.3;

var q = 3*4.2;
var r = 15/10;

var s = 15 % 10;
var t = (1+2) * (3/4);



//Comparisons

console.log(1 !== 3);

if (1<2) {
    
    console.log("Yes");
} else  {
    console.log("No");
    } 


//The Math Object

var u = Math.round(Math.random()*10);
var v = Math.round(2,3);
var w = Math.floor(3.7);
var x = Math.ceil(6.2);
var y = Math.pow(2,5);
var z = Math.sqrt(9);

    