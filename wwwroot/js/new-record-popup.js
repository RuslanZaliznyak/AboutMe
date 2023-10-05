var addButton = document.querySelector('.btn.add');

addButton.addEventListener('click', function (e) {
    e.preventDefault();

    var xhr = new XMLHttpRequest();

    xhr.open('GET', '/Blog/Add', true);

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            
            var popupDiv = document.createElement('div');
            popupDiv.className = 'popup';
            popupDiv.innerHTML = xhr.responseText;
            document.body.appendChild(popupDiv);
        }
    };

    
    xhr.send();
});



