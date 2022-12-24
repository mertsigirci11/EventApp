<template>
    <div class="container">
        <profile-card></profile-card>
        
        <div class="contents"> 
            <div class="newContent">
            <new-content></new-content>
            </div>
            <div class="contentContainer">
            <content></content>
            <content></content>
            <content></content>
            <!-- 
                v-for ile verileri yolla her bir veriyi content componentinin içine 
                parametre olarak yolla.
                Component parametreye göre verileri listelesin.
            -->
            </div>  
        </div>
        <div class="event-recommend">
            <event-recommend-card></event-recommend-card>
        </div>
    </div>
</template>

<script>

</script>

<style>
    .container{
    display: flex;
  }

.event-recommend{
    width: 23%;
  }

  .contents{
    width: 54%;
    /* border: 1px solid yellow; */
  }

  .contents .contentContainer{
    height: auto;
    width: 80%;
    margin: auto;
    margin-top: 30px;
    margin-bottom: 25px;
    display: flex;
    flex-direction: column;
  }
</style>