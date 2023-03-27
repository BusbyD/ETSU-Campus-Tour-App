// Initializes the dropdowns on the page
function initDropdowns() {
    const dropdown = document.querySelectorAll(".dropdown");
    // Set content for each dropdown description
    dropdown.forEach(dropdown => {
        const dropdownSelect = dropdown.children[0],
            options = dropdown.children[1].children,
            dropdownTitleText = dropdown.children[2];
        // When the user clicks the dropdown, show the dropdown content
        // or hide the content if it is already shown
        dropdownSelect.addEventListener("click", () =>
            dropdown.classList.toggle("active")
        );
    });
}


const checkboxes = document.querySelectorAll('.checkbox');

checkboxes.forEach(checkbox => {
    checkbox.addEventListener('click', () => {
        console.log('Checkbox clicked');
        // Add your code here to handle checkbox click event
    });
});




initDropdowns();