function sarvesData(){
    var xhr=new XMLHttpRequest();
    xhr.onreadystatechange=function(){
        if(this.readyState==4 && this.status==200){
            document.getElementById("sarvesh1").innerHTML=this.responseText;
        }
    };
    xhr.open("GET","sarvesh.txt",true);
    xhr.send();

}
function ramesData(){
    var xhr=new XMLHttpRequest();
    xhr.onreadystatechange=function(){
        if(this.readyState==4 && this.status==200){
            document.getElementById("ramesh1").innerHTML=this.responseText;
        }
    };
    xhr.open("GET","ramesh.txt",true);
    xhr.send();

}
function suresData(){
    var xhr=new XMLHttpRequest();
    xhr.onreadystatechange=function(){
        if(this.readyState==4 && this.status==200){
            document.getElementById("suresh1").innerHTML=this.responseText;
        }
    };
    xhr.open("GET","suresh.txt",true);
    xhr.send();

}