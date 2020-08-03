var button = document.createElement("button");
var button1 = document.createElement("button");
button.innerHTML = "OK";
button1.innerHTML = "CANCEL";

var body = document.getElementsByTagName("body")[0];
body.appendChild(button);
body.appendChild(button1);

button.addEventListener ("click", function() {
  optionalPower(2,3);
});

button1.addEventListener ("click", function() {
  optionalPower(3,2);
});

function optionalPower(a,b){
		var x = Math.pow(a,b);
        document.write(x);
        alert(x);        
}