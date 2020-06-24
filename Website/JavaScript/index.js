
var i = 0;
var sentences = ["Farming","Money","Economy","Rivalry"];
var txt = 'Lorem ipsum dummy text blabla. DADADADADADASDAD';
var sentenceIndex=0;
var k = txt.length;
var speed = 250;

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

/*var btn = $("#toTop");
btn.hover(()=>{
    btn.colo
},()=>{

});*/