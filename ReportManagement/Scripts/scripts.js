/*!
    * Start Bootstrap - SB Admin v7.0.7 (https://startbootstrap.com/template/sb-admin)
    * Copyright 2013-2023 Start Bootstrap
    * Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-sb-admin/blob/master/LICENSE)
    */
    // 
// Scripts
// 

window.addEventListener('DOMContentLoaded', event => {

    // Toggle the side navigation
    const sidebarToggle = document.body.querySelector('#sidebarToggle');
    if (sidebarToggle) {
         /*Uncomment Below to persist sidebar toggle between refreshes*/
        if (localStorage.getItem('sb|sidebar-toggle') === 'true') {
             document.body.classList.toggle('sb-sidenav-toggled');
        }
        sidebarToggle.addEventListener('click', event => {
            event.preventDefault();
            document.body.classList.toggle('sb-sidenav-toggled');
            localStorage.setItem('sb|sidebar-toggle', document.body.classList.contains('sb-sidenav-toggled'));
        });
    }

});
document.addEventListener('DOMContentLoaded', function () {
    // Khôi phục trạng thái từ localStorage
    const accordionStates = JSON.parse(localStorage.getItem('accordionStates')) || {};

    for (const [id, isOpen] of Object.entries(accordionStates)) {
        const collapseElement = document.getElementById(id);
        if (collapseElement) {
                collapseElement.classList.toggle('show', isOpen);
        }
    }
    const accordionElements = document.querySelectorAll('.collapse');
    accordionElements.forEach(element => {
        element.addEventListener('shown.bs.collapse', function () {
            const id = element.getAttribute('id');
            accordionStates[id] = true;
            localStorage.setItem('accordionStates', JSON.stringify(accordionStates));
        });

        element.addEventListener('hidden.bs.collapse', function () {
            const id = element.getAttribute('id');
            accordionStates[id] = false;
            localStorage.setItem('accordionStates', JSON.stringify(accordionStates));
        });
    });
});
