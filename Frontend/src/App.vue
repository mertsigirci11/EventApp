<template>
  <div v-if="path != '/login'">
    <navigation-bar></navigation-bar>
    <main>
      <router-view ></router-view>
  </main>
  </div>
  <div v-else>
    <login></login>
  </div>
      
    
  
</template>

<script>
export default{
    data(){
        return{
            urlPath:"",
        }
    },
    created(){
      this.urlPath = this.$route.fullPath;
    },
    computed:{
      path(){
        return this.urlPath = this.$route.fullPath;
      }
    }
}
</script>

<style>
  *{
    background-color: #c2c2c2;
    box-sizing: border-box;
  }
  



  button:hover{
    cursor: pointer;
  }

  main{
    background-color: #c2c2c2;
  }
</style>