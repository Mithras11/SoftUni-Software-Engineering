function attachEvents() {
    const btnLoadPosts = document.querySelector('#btnLoadPosts');
    const btnViewPost = document.querySelector('#btnViewPost');

    const dropDown = document.querySelector('#posts');

    btnLoadPosts.addEventListener('click', loadPosts);
    btnViewPost.addEventListener('click', loadComments);

    async function loadPosts(event) {

        let postsUrl = 'http://localhost:3030/jsonstore/blog/posts';

        try {

            let response = await fetch(postsUrl);
            let data = await response.json();

            Object.values(data).forEach(post => {
                let option = document.createElement('option');
                option.setAttribute('value', post.id);
                option.textContent = post.title;
                dropDown.appendChild(option);
            });

        } catch {

            throw new Error('Error loading posts in drop down');
        }
    }

    async function loadComments(event) {

        let selectedId = dropDown.options[dropDown.selectedIndex].value; //!!!        
        let currPostUrl = `http://localhost:3030/jsonstore/blog/posts/${selectedId}`;

        let postData;
        let h1 = document.querySelector('#post-title');
        let postUl = document.querySelector('#post-body');

        try {

            let postResponse = await fetch(currPostUrl);
            postData = await postResponse.json();

            h1.textContent = postData.title;
            postUl.textContent = postData.body;

        } catch {

            throw new Error('Error loading post');
        }

        let commentsUrl = ' http://localhost:3030/jsonstore/blog/comments';
        let commentsUl = document.querySelector('#post-comments');

        try {

            let commentsResponse = await fetch(commentsUrl);
            let commentsData = await commentsResponse.json();

            commentsUl.innerHTML = '';

            Object.values(commentsData).forEach(c => {

                if (c.postId === postData.id) {
                    let li = document.createElement('li');
                    li.setAttribute('id', c.id);
                    li.textContent = c.text;
                    commentsUl.appendChild(li);
                }
            });

        } catch {

            throw new Error('Error loading comments');
        }
    }
}

attachEvents();