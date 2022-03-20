/*
<ul class="menu">
    <li>
        <a asp-controller="Home" asp-action="Index">Головна</a>
    </li>
    <li>
        <a asp-controller="Home" asp-action="Theory">Теоретичний матеріал</a>
    </li>
    <li>
        <a asp-controller="Home" asp-action="Testing">Тестування</a>
    </li>
    <li>
        <a asp-controller="Home" asp-action="Autors">Автори</a>
    </li>
</ul>
*/

document.getElementById('nav').onmouseover = function (event) {
    let target = event.target;
    //alert(1);
    if (target.className == 'menu-item') {
        let s = target.getElementByClassName('submenu-item');
        closeMenu();
        s[0].style.display = 'block';
    }
}
document.onmouseover = function (event) {
    //alert(2);
    let target = event.target;
    if (target.className != 'menu-item' &&
        target.className != 'submenu-item') {
        closeMenu();
    }
}

function closeMenu() {
    //alert(3);
    let menu = document.getElementById('nav');
    let subm = document.getElementByClassName('submenu-item')
    for (let i = 0; i < subm.length; i++) {
        subm[i].style.display = "none"
    }
}