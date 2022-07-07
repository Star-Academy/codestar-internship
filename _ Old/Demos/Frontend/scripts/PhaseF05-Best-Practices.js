const STATUS_CLASS_NAME = 'fixed';

const toggleStatusButton = document.querySelector('body>button');
const article = document.querySelector('body>article');

const toggleStatus = () => {
  article.classList.toggle(STATUS_CLASS_NAME);
};
