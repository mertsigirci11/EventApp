import { createApp } from 'vue'
import App from './App.vue'

import { createRouter, createWebHistory } from 'vue-router';

import NavigationBar from './components/Navbar/NavigationBar.vue';
import Content from './components/Contents/Content.vue';
import NewContent from './components/Contents/NewContent.vue';
import ProfileCard from './components/Profile/ProfileCard.vue';
import EventRecommendCard from './components/Recommend/EventRecommendCard.vue';
import Index from './components/Index/Index.vue';
import SingleContent from './components/Contents/SingleContent.vue';
import Comment from './components/Contents/Comment.vue';
import OwnProfile from './components/Profile/OwnProfile.vue';
import OtherProfile from './components/Profile/OtherProfile.vue';
import FriendList from './components/Recommend/FriendList.vue';
import User from './components/Search/User.vue';
import SearchUser from "./components/Search/SearchUser.vue";
import Login from "./components/Login/Login.vue";





const router = createRouter({
    history:createWebHistory(),
    routes:[
    {
        name:"index",
        path:"/",
        component: Index,
    },
    {
        name:"single-content",
        path:"/content/:id",
        component:SingleContent
    },
    {
        name:"own-profile",
        path:"/profile",
        component:OwnProfile
    },
    {
        name:"other-profile",
        path:"/profile/:id",
        component:OtherProfile
    },
    {
        name:"search",
        path:"/search",
        component:SearchUser
    },
]
})

const app = createApp(App);
app.component("navigation-bar", NavigationBar);
app.component("new-content",NewContent);
app.component("post-content",Content);
app.component("profile-card",ProfileCard);
app.component("content",Content);
app.component("event-recommend-card",EventRecommendCard);
app.component("index",Index);
app.component("comment",Comment);
app.component("friend-list",FriendList);
app.component("user",User);
app.component("login",Login);
app.use(router);
app.mount('#app');


