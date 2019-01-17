//window.onload = function () {
//    document.getElementById('purchase').onclick = function () {
//        console.log('work');
//        //document.getElementsByTagName('body')[0].style.background = 'green';
//        localStorage.setItem('product','boots');
//    }
//}
function edit(x) {
    var ID = document.getElementById(x);
    localStorage.setItem('id-' + x, ID.dataset.name);
}

function remove(x) {
    console.log(x);
    var ID = document.getElementById(x);
    localStorage.removeItem('id-' + x);
}

function ls() {
    console.log('222');
}