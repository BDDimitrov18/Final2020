
var i = 0;
var sentences = ["Farming","Money","Economy","Rivalry"];
var txt = 'Lorem ipsum dummy text blabla. DADADADADADASDAD';
var sentenceIndex=0;
var k = txt.length;
var speed = 100;

function typeWriter() {

    if (i < txt.length) {
        document.getElementById("demo").textContent += sentences[sentenceIndex].charAt(i);
        i++;
        setTimeout(typeWriter, speed);
    }
    else
        setTimeout(deleteText,speed);
}

async function deleteText() {
    if (i > 0) {
        document.getElementById("demo").textContent = sentences[sentenceIndex].substr(0, i-1);
        console.log(txt.substr(0, i));
        i--;
        setTimeout(deleteText, speed);
    }
    else
    {
        sentenceIndex++;
        if(sentenceIndex>=sentences.length) sentenceIndex=0;
        setTimeout(typeWriter(),500);
    }
}

function lightMode()
{
    $("body").css("background-color","white");
    $(".HRstyle").css("border-color","rgb(56, 56, 56)");
    $("body").css("color","black");
}

function darkMode()
{
    $("body").css("background-color","#2f3640");
    $(".HRstyle").css("border-color","white");
    $("body").css("color","white");
}