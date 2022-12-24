<template>
    <div class="preference">  
              <button @click="prefer='post'">New Post</button>
              <button @click="prefer='event'">New Event</button>
            </div>
            <div v-if="prefer=='post'" class="createPost">
              <div class="postText">
                <textarea id="postText" name="postText" rows="4" cols="80" style="width: 100%; height: 100%; background-color: inherit; border: none; resize: none; font-size: 18px;" placeholder="Write something" ></textarea>
              </div>
            </div>

            <div v-if="prefer=='event'" class="createEvent"> 
              <div class="eventText">
                <textarea id="eventText" name="eventText" rows="4" cols="80" style="width: 100%; height: 100%; background-color: inherit; border: none; resize: none; font-size: 18px;" placeholder="Write something" ></textarea>
              </div>
              <div class="eventAddress">
                <textarea id="eventAddress" name="eventAddress" rows="4" cols="80" style="width: 100%; height: 100%; background-color: inherit; border: none; resize: none; font-size: 18px;" placeholder="Write address" ></textarea>
              </div>
              <div class="eventTime">
                <div class="startingTime">
                  <p style="background-color: inherit; color: #5c5c5c;">
                    Starting Time: <input type="datetime-local" name="start" id="start"   style="display: inline; background-color: #eeeeee; border: none;">
                  </p>
                  
                </div>
                <div class="endingTime">
                  <p style="background-color: inherit; color: #5c5c5c;">
                    Ending Time: <input type="datetime-local" name="end" id="end" style="display: inline; background-color: #eeeeee; border: none; " >
                  </p>
                  
                </div>
              </div>
            </div>
            <div class="newContentSender">
              <button class="shareNewContent">Share</button>
            </div>
</template>

<script>
export default{
    data(){
        return{
            prefer:'post',
        }
    }
}
</script>

<style>
.newContent{
    height: auto;
    width: 80%;
    margin: auto;
    margin-top: 30px;
    margin-bottom: 20px;
    /* background-color: beige; */
  }

  .newContent .preference{
    width: 100%;
    height: 40px;
    /* background-color: beige; */
    display: flex;
    align-items: center;
    justify-content: flex-start;
  }

  .preference button{
    border: none;
    width: 153px;
    height: 35px;
    margin-left: 15px;
    margin-right: 15px;
    background-color: #f7f7f7;
    border: 2px solid gray;
    color: #5c5c5c;
  }

  /*Create Post*/
  .createPost{
    width: 100%;
    height: 110px;
    background-color: #f7f7f7;
    border: 2px solid gray;
    margin-bottom: 11px;
  }

  .createPost .postText{
    width: 100%;
    height: 100%;
    background-color: #f7f7f7;
    border: none;
  }
  /*Create Post*/

  /*Create Event*/
  .createEvent{
    display: flex;
    flex-direction: column;
    width: 100%;
    height: 200px;
  }

  .createEvent .eventText{
    width: 100%;
    height: 100%;
    background-color: #f7f7f7;
    border: 2px solid gray;
    border-bottom: none;
  }
  
  .createEvent .eventAddress{
    width: 100%;
    height: 50px;
    background-color: #f7f7f7;
    border: 2px solid gray;
    /* border-top: none; */
  }

  .createEvent .eventTime{
    width: 100%;
    height: 50px;
    background-color: #f7f7f7;
    border: 2px solid gray;
    border-top: none;
  }

  .eventTime .startingTime{
    width: 100%;
    height: 25px;
    background-color: #f7f7f7;
    border: 1px solid gray;
    border-top: none;
    border-left: none;
    border-right: none;
  }

  .eventTime .endingTime{
    width: 100%;
    height: 25px;
    background-color: #f7f7f7;
    border: 1px solid gray;
    border-top: none;
    border-left: none;
    border-right: none;
  }
  /*Create Event*/

  
  /*Share button*/
  .newContentSender{
    display: flex;
    justify-content: flex-end;
    background-color: inherit;
    margin-top: 6px;
    margin-bottom: 6px;
  }

  .newContentSender button{
    border: 2px solid gray;
    width: 83px;
    height: 27px;
    background-color: #f7f7f7;
    color: #5c5c5c;
  }
  /*Share button*/
</style>