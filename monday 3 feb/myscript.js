function formvalidation(){
    var name=document.getElementById("1").value;
    var ids=document.getElementById("3").value;
    var pas=document.getElementById("4").value;
    if(ids==pas){
        alert("submitted" +name);
    }
    else{
        alert("fill again");
    }
}