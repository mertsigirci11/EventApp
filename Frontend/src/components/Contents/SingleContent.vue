<template>
        <p>ID: {{ id }}</p>
        <p>ID: asdasd</p>
    <div class="singleContentContainer">
        <div v-if="content=='post'">
            <div class="up">
                <div class="username">@username</div>
                <div class="date">Date</div>
            </div>
            <div class="contentText">
                <p>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. In nostrum voluptas sint laudantium, qui facilis perspiciatis amet vero non dolore, nemo error repudiandae deleniti ad autem tempora assumenda ipsam laboriosam molestias quisquam odit. Assumenda itaque dicta asperiores amet modi ipsa vel tenetur perferendis dolore odit cupiditate quisquam voluptatum eligendi, qui sed corrupti esse mollitia unde officiis. Incidunt delectus sed voluptatibus fugit rem, illum dignissimos quis accusamus tempora maxime quas. Quia necessitatibus neque eum impedit voluptas, saepe a recusandae aliquid, nostrum sint fugit ex illum, iure excepturi. Doloribus aperiam qui officiis!
                Lorem ipsum dolor, sit amet consectetur adipisicing elit. Suscipit pariatur, quis, ab fugit, corrupti doloremque veritatis distinctio quibusdam nihil quo itaque libero sed ratione rerum dignissimos similique necessitatibus est voluptate ducimus. Impedit veniam, hic nisi commodi nesciunt amet, laborum aut, doloremque minus cumque placeat perferendis consequuntur assumenda. Quidem, similique tempore!
                </p>
            </div>
            <div class="actionBar">
                <div class="counts">
                    <p>23 Likes</p>
                    <p>15 Comments</p>
                    <p>9 Sharing</p>
                </div>
                <div class="buttons">
                    <button>Like</button>
                    <!-- <button>Remove Like</button> -->
                    <button>Share</button>
                    <!-- <button>Remove Sharing</button> -->
                </div>
            </div>
            <div class="comments">
                <comment></comment>
                <comment></comment>
                <comment></comment>
            </div>
            <div class="makeAComment">
                <textarea id="userComment" name="userComment" rows="4" cols="80" style="width: 100%; height: 60%; background-color: inherit;  resize: none; font-size: 18px;" placeholder="Write something" ></textarea>
                <button>Send</button>
            </div>
        </div>
        <div v-else="content=='event'">
            <div class="up">
                <div class="username">@username</div>
                <div class="date">Date</div>
            </div>
            <div class="contentText">
                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. In nostrum voluptas sint laudantium, qui facilis perspiciatis amet vero non dolore, nemo error repudiandae deleniti ad autem tempora assumenda ipsam laboriosam molestias quisquam odit. Assumenda itaque dicta asperiores amet modi ipsa vel tenetur perferendis dolore odit cupiditate quisquam voluptatum eligendi, qui sed corrupti esse mollitia unde officiis. Incidunt delectus sed voluptatibus fugit rem, illum dignissimos quis accusamus tempora maxime quas. Quia necessitatibus neque eum impedit voluptas, saepe a recusandae aliquid, nostrum sint fugit ex illum, iure excepturi. Doloribus aperiam qui officiis!
                    Lorem ipsum dolor, sit amet consectetur adipisicing elit. Suscipit pariatur, quis, ab fugit, corrupti doloremque veritatis distinctio quibusdam nihil quo itaque libero sed ratione rerum dignissimos similique necessitatibus est voluptate ducimus. Impedit veniam, hic nisi commodi nesciunt amet, laborum aut, doloremque minus cumque placeat perferendis consequuntur assumenda. Quidem, similique tempore!
                </p>
            </div>
            <div class="eventAddress">
                <p>
                <p style="color: red; font-weight: 800;">Address :</p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ipsa dignissimos laudantium excepturi, temporibus eveniet mollitia voluptates accusantium ea architecto. Recusandae deserunt voluptate exercitationem obcaecati ratione. Laudantium excepturi vero suscipit voluptatum!
                </p>
            </div>
            <div class="duration">
                <div class="starting-time">
                    <p><span style="color: red; font-weight: 800; background-color: inherit;">Starting Date: </span>GG/AA/YYYY HH:MM</p>
                </div>
                <div class="ending-time">
                    <p><span style="color: red; font-weight: 800; background-color: inherit;">Ending Date: </span>GG/AA/YYYY HH:MM</p>
                </div>
            </div>
            <div class="actionBar">
                <div class="counts">
                    <p>23 Likes</p>
                    <p>18 Participates</p>
                    <p>15 Comments</p>
                    <p>9 Sharing</p>
                </div>
                <div class="buttons">
                    <button>Like</button>
                    <!-- <button>Remove Like</button> -->
                    <button>Attend</button>
                    <!-- <button>Cancel Attend</button> -->
                    <button>Comment</button>
                    <button>Share</button>
                    <!-- <button>Remove Sharing</button> -->
                </div>
            </div>
            <div class="comments">
                <comment></comment>
                <comment></comment>
                <comment></comment>
            </div>
            <div class="makeAComment">
                <textarea id="userComment" name="userComment" rows="4" cols="80" style="width: 100%; height: 60%; background-color: inherit;  resize: none; font-size: 18px;" placeholder="Write something" ></textarea>
                <button>Send</button>
            </div>
        </div>
    </div>
    
</template>

<script>
export default{
    data(){
        return{
            id:0,
            content:'event',
        }
    },
    created(){
        this.id = this.$route.params.id;
    }
}
</script>

<style>
  .singleContentContainer{
    width: 60%;
    display: flex;
    justify-content: flex-start;
    margin-left: 7%;
    box-sizing: border-box;
    
  }

  .comments{
    height: auto;
    border: 2px solid gray;
    border-top: none;
    display: flex;
    flex-direction: column;
    background-color: #f7f7f7;
    padding: 30px;
  }

  .makeAComment{
    padding: 5px;
    height: 130px;
    background-color: #f7f7f7;
    border: 2px solid gray;
    border-top: none;
    display: flex;
    flex-direction: column;
  }

  .makeAComment textarea{
    background-color: red;
    border: 2px solid gray;
    padding: 5px;
  }

  .makeAComment button{
    margin-top: 5px;
    width: 83px;
    height: 27px;
    border: none;
    background-color: #5c5c5c;
    color: #f7f7f7;
    align-self: flex-end;
  }
  
</style>