// JScript File for TextArea
// Keep user from entering more than maxLength characters
function doKeypress(control){
    maxLength = control.attributes["maxLength"].value;
    value = control.value;
     if(maxLength && value.length > maxLength-1){
     
          var oTR = control;
          var iInsertLength = maxLength - 1;
          var sData = control.value.substr(0,iInsertLength);
         
          control.value = sData;
          return false;
          
     }
}
function doKeypressExplorer(control){
    maxLength = control.attributes["maxLength"].value;
    value = control.value;
     if(maxLength && value.length > maxLength-1){
          event.returnValue = false;
          maxLength = parseInt(maxLength);
     }
}
// Cancel default behavior
function doBeforePaste(control){
    maxLength = control.attributes["maxLength"].value;
     if(maxLength)
     {
         event.returnValue = false;
      
     }
     
}

// Cancel default behavior and create a new paste routine
function doPaste(control){

    maxLength = control.attributes["maxLength"].value;
    value = control.value;
   
     if(maxLength){
          event.returnValue = false;
          maxLength = parseInt(maxLength);
          var oTR = control.document.selection.createRange();
          var iInsertLength = maxLength - value.length + oTR.text.length;
          var sData = window.clipboardData.getData("Text").substr(0,iInsertLength);
          oTR.text = sData;
         
     }
}
function doPasteFirefox(control){

    maxLength = control.attributes["maxLength"].value;
    value = control.value;
   
     if(maxLength && value.length > maxLength-1){
      
         var oTR = control;
         var iInsertLength = maxLength - 1;
         var sData = control.value.substr(0,iInsertLength);
         control.value = sData;
         return false;
     }
}
function alternar_color_tabla() {
  var col=false;
  tabla = document.getElementById('matrizObjetivosControl');
  for (i=0; ele = tabla.getElementsByTagName('tr')[i]; i++) {
    ele.style.background = (col) ? '#FFFFFF' : '#F9F9F9';
    col = !col;
  }
}