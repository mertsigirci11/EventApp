<template>
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
        <button>Comment</button>
        <button>Share</button>
        <!-- <button>Remove Sharing</button> -->
        </div>
    </div>
    </div>
    <div v-if="content=='event'">
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
                <p>Starting Date: GG/AA/YYYY HH:MM</p>
            </div>
            <div class="ending-time">
                <p>Ending Date: GG/AA/YYYY HH:MM</p>
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
    </div>
    
</template>

<script>
export default{
    data(){
        return{
            content:'post',
        }
    }
}
</script>

<style>
  .up{
    display: flex;
    justify-content: space-between;
    margin-top: 15px;
  }

  .up .date{
    height: 25px;
    width: 120px;
    background-color: #f7f7f7;
    border: 2px solid gray;
    border-bottom: none;
    text-align: center;
    padding-top: 3px;
    align-self: flex-end;
  }

  .username{
    height: 35px;
    width: 150px;
    background-color: #f7f7f7;
    border: 2px solid gray;
    border-bottom: none;
    text-align: center;
    padding-top: 6px;
  }

  .contentText{
    /* height: 190px; */
    height: auto;
    width: 100%;
    background-color: #f7f7f7;
    border: 2px solid gray;
    border-bottom: none;
    text-align: justify;
    padding: 6px;
  }

  .eventAddress{
    height: auto;
    width: 100%;
    background-color: #f7f7f7;
    border: 2px solid gray;
    padding-bottom: 5px;
    text-align: justify;
    padding: 6px;
  }

  .eventAddress p{
    background-color: inherit;
  }
  .counts{
    height: 35px;
    width: 100%;
    background-color: #f7f7f7;
    border: 2px solid gray;
    border-top: none;
    border-bottom: none;
    padding-top: 6px;
  }

  .contentText p{
    background-color: inherit;
    margin-bottom: 5px;
  }

  .buttons{
    height: 45px;
    width: 100%;
    background-color: #f7f7f7;
    border: 2px solid gray;
    border-top: none;
    display: flex;
    justify-content: space-around;
    align-items: center;
  }

  


  /*Event Duration*/
  .duration{
    background-color: inherit;
  }

  .duration p{
    background-color: #f7f7f7;
    border-left: 2px solid gray;
    border-right: 2px solid gray;
    padding-left: 5px;
    padding-bottom: 5px;
  }
  /*Event Duration*/


  /*content-post & content-event*/
  .actionBar{
    border-top: 2px solid gray;
  }

  .counts p{
    display: inline;
    font-size: 18px;
    margin-left: 10px;
    margin-right: 20px;
    background-color: inherit;
    color: #5c5c5c;
  }

  .buttons button{
    border: none;
    width: 120px;
    height: 30px;
    background-color: inherit;
    border: 2px solid gray;
  }
  /*content-post & content-event*/
</style>