<template>
    <div class="profile">
        <div class="profileBox">
        <p>Name - Surname</p>
        <p>@Username</p>
        <p>Bio Text</p>
        </div>
    </div>
</template>

<script>

</script>

<style>
/*Profile box*/
.profile{
    width: 23%;
  }

  .profileBox{
    width: 80%;
    height: 300px;
    margin: auto;
    margin-top: 30px;
    margin-bottom: 30px;
    background-color: #f7f7f7;
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  .profileBox p{
    margin-bottom: 10px;
    margin-top: 15px;
    font-size: 18px;
    font-weight: bold;
    color: #3f3f3f;
    background-color: inherit;
  }
/*Profile box*/
</style>