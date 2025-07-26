import React,{Component} from 'react';
import Post from './Post';

class Posts extends Component{
  constructor(props){
    super(props);
    this.state={
      posts:[]
    }
  }
 loadPosts() {
  fetch("https://dummyjson.com/posts")
    .then(response => response.json())
    .then(data => {
      this.setState({ posts: data.posts }); // ✅ Notice .posts here
    })
    .catch(error => {
      console.error("Error fetching posts:", error);
      this.setState({ hasError: true });
    });
}

componentDidMount(){
  this.loadPosts();
}
render(){
  return(
    <div>
      <h2>Posts</h2>
      {
        this.state.posts.map(post=>(
          <Post key={post.id} title={post.title} body={post.body}></Post>
        ))
      }
    </div>
  );
}
componentDidCatch(error,info){
  alert("Error occurred");
}

}

export default Posts;
