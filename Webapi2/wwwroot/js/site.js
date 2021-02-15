const uri = 'api/TodoItems';
let win = [];

function getWindows() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
}