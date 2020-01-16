function checkPalindrome(word) {
    let firstPart = "";
    for (let i = 0; i < parseInt(word.length/2); i++) {
        firstPart += word[i];
    }
    let secondPart = "";
    for (let i = word.length-1; i >= parseInt(word.length/2); i--) {
        secondPart += word[i];
    }

    if (firstPart == secondPart){
        console.log("true");
    }
    else{
        console.log("false");
    }
}

function isPalindrome(text) {
    let textLength = text.length;
    let leftPart = text.substring(0,textLength / 2);
    text = reverseString(text);
    let rightPart = text.substring(0, textLength / 2);

    let isPalindrome  = leftPart === rightPart;

    console.log(isPalindrome);

    function reverseString(string){
        return string.split("").reverse().join("");
    }
}

checkPalindrome("12aa21");
isPalindrome("racecar");