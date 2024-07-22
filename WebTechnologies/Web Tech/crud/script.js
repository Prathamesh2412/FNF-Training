document.addEventListener('DOMContentLoaded', () => {
    const txtInput = document.getElementById("newtask");
    const addButton = document.getElementById("btnadd");
    const taskList = document.getElementById("tasklist");

    addButton.addEventListener("click", addData);

    function addData() {
        const txtItem = txtInput.value.trim();
        if (txtItem === "") {
            alert("Enter a task to add");
            return;
        }

        const listItem = document.createElement("li");

        const taskSpan = document.createElement("span");
        taskSpan.textContent = txtItem;
        listItem.appendChild(taskSpan);

        const editButton = document.createElement('button');
        editButton.textContent = "Edit";
        editButton.addEventListener('click', () => editTask(listItem, taskSpan));
        listItem.appendChild(editButton);

        const deleteButton = document.createElement('button');
        deleteButton.textContent = 'Delete';
        deleteButton.addEventListener('click', () => deleteTask(listItem));
        listItem.appendChild(deleteButton);

        taskList.appendChild(listItem);
        txtInput.value = '';
    }

    function editTask(listItem, taskSpan) {
        const newTaskText = prompt('Edit task:', taskSpan.textContent);
        if (newTaskText !== null && newTaskText.trim() !== '') {
            taskSpan.textContent = newTaskText.trim();
        }
    }

    function deleteTask(listItem) {
        taskList.removeChild(listItem);
    }
});
