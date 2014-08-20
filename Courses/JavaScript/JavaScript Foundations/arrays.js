//JavaScript Arrays
/*
var x = ['some', 'words', 'here', 'extra'];
//console.log(x.length);

var y = ['a string', 3, ['a sub array', 2, 3, 4], 'threehouse', function(a,b){return a+b}];

var z = [];

var a = new Array(50);
*/

// Getting and Setting
/*
var my_array = ['Hello', 42, true, function(a) {return a*2}];

var word = my_array[0];
var answer = my_array[1];
var doubler = my_array[3];
console.log(10);

my_array[1] = 144;
var new_answer = my_array[1];

my_array[4] = 'a new string';
my_array[my_array.length] = "new"
my_array[my_array.length] = "new +1"
*/


//Methods part 1

//push method
/*
var my_array = [2,3,4];
console.log(my_array.toString());

my_array.push(5);
console.log(my_array.toString());


//pop

var value = my_array.pop();
console.log(my_array.toString());
*/


//unshift method
/*
var my_array = [2,3,4];
console.log(my_array.toString());

my_array.unshift(1);
console.log(my_array.toString());

// shift method
var value = my_array.shift();
console.log(my_array.toString());
*/

//Methods part 2
/*
var my_array = [10, 44,32, 100, 0, 44, 3, 4];
console.log(my_array.toString());

my_array.sort(function (a, b) {
    //return a - b
    return Math.random() - 0.5
    });
console.log(my_array.toString());
*/
/*
var my_array = [1,2,3,4,5];
console.log(my_array.toString());
my_array.reverse();
console.log(my_array.toString());
*/

/*
var x = [1,2,3];
var y= [4,5,6];
var z = x.concat(7,8,9, [10,11,12]);

console.log(x);
console.log(y);
console.log(z);
*/
/*
var my_array = [0,1,2,3,4,5];
var result = my_array.slice(1, 4);
console.log(result); // 1,2,3
*/
/*
var words = ["these", "are", "some", "words"];
var results = words.join(' ');
*/

var my_array = [0,1,2,3,4,5,6];
console.log(my_array.toString());

my_array.splice(2, 3, 'two', 'TWO', 'something else');

console.log(my_array.toString());