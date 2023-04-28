////window.myFunctions = {
////    toggleDisplayImgClass: function () {
////        document.querySelector('.cont').classList.toggle('s-signup');
////    }
////};
window.toggleDisplayImgClass = function () {
    document.querySelector('.displayImg-btn').addEventListener('click', function () {
	document.querySelector('.cont').classList.toggle('s-signup')
    });
}

