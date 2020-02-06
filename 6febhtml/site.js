document.getElementById("amazon").addEventListener('click',loadsite);
function loadsite(){
    var xhr= new XMLHttpRequest();
    xhr.open('GET','https://www.amazon.com/',true);
    xhr.onload=function(){
        if(this.status=200){
            this.responseURL;
        }
        else if(this.status=404){
            document.getElementById("amazon").innerHTML="page not found";
        }
    }
    xhr.send();
}