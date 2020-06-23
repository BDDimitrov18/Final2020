/*const typedTextSpan = document.querySelector(".typed-text");
const cursorSpan = document.querySelector(".cursor");

const textArray = ["hard", "fun", "a journey", "LIFE"];
const typingDelay = 200;
const erasingDelay = 100;
const newTextDelay = 2000; // Delay between current and next text
let textArrayIndex = 0;
let charIndex = 0;

function type() {
    if (charIndex < textArray[textArrayIndex].length) {
        if (!cursorSpan.classList.contains("typing")) cursorSpan.classList.add("typing");
        typedTextSpan.textContent += textArray[textArrayIndex].charAt(charIndex);
        charIndex++;
        setTimeout(type, typingDelay);
    } else {
        cursorSpan.classList.remove("typing");
        setTimeout(erase, newTextDelay);
    }
}

function erase() {
    if (charIndex > 0) {
        if (!cursorSpan.classList.contains("typing")) cursorSpan.classList.add("typing");
        typedTextSpan.textContent = textArray[textArrayIndex].substring(0, charIndex - 1);
        charIndex--;
        setTimeout(erase, erasingDelay);
    } else {
        cursorSpan.classList.remove("typing");
        textArrayIndex++;
        if (textArrayIndex >= textArray.length) textArrayIndex = 0;
        setTimeout(type, typingDelay + 1100);
    }
}

document.addEventListener("DOMContentLoaded", function() { // On DOM Load initiate the effect
    if (textArray.length) setTimeout(type, newTextDelay + 250);
});*/

/*function test(letter) {
    var txt = $("#text").text();
    $("#text").html(txt + letter);
    console.log(txt);
    console.log(letter);
}*/

//test("leg");

var i = 0;
var txt = 'Lorem ipsum dummy text blabla. DADADADADADASDAD';
var k = txt.length;
var speed = 50;

function typeWriter() {

    if (i < txt.length) {
        document.getElementById("demo").textContent += txt.charAt(i);
        i++;
        setTimeout(typeWriter, speed);
    }
    else
        setTimeout(deleteText,speed);
}

async function deleteText() {
    if (i > 0) {
        document.getElementById("demo").textContent = txt.substr(0, i-1);
        console.log(txt.substr(0, i));
        i--;
        setTimeout(deleteText, speed);
    }
}