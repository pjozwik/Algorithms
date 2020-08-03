function fixAge(){
    array = [];
    for( i =0; i < arguments.length; i++){
        if(arguments[i] >= 18 && arguments[i] <= 60){
            array.push(arguments[i].toString());
        }
    }
    if(Array.isArray(array)) var result = array.join(",");
    else var result = "NA";

    return result;
}

console.log(fixAge(18,3,30,22,11,60));
document.write(fixAge(18,3,30,22,11,60));