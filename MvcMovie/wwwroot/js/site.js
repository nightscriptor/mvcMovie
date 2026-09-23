// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

(function () {
    var html = document.documentElement;
    var icon = document.getElementById('themeIcon');
    var button = document.getElementById('themeToggle');

    function updateIcon() {
        // w ciemnym pokazujemy słońce (przełącz na jasny), w jasnym księżyc
        icon.textContent = html.getAttribute('data-bs-theme') === 'dark' ? '☀️' : '🌙';
    }

    button.addEventListener('click', function () {
        var next = html.getAttribute('data-bs-theme') === 'dark' ? 'light' : 'dark';
        html.setAttribute('data-bs-theme', next);
        try { localStorage.setItem('theme', next); } catch (e) { }
        updateIcon();
    });

    updateIcon();
})();