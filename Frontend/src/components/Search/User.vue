<template>
    <div class="userBox">
        <span class="user-NameSurname">Name Surname</span>
        <span class="user-Username">Username</span>
        <button class="visitUser">Visit</button>
    </div>
</template>    

<script>

</script>

<style>
    .userBox{
        display: flex;
        justify-content: space-evenly;
        align-items: center;
        background-color: #f7f7f7;
        margin-bottom: 10px;
        width: 100%;
        padding: 6px;
    }

    .user-NameSurname{
        padding: 6px;
        font-style: italic;
        font-weight: bold;
        font-size: 20px;
    }

    .user-Username{
        padding: 6px;
        font-weight: bold;
        font-size: 18px;
    }

    .visitUser{
        border: none;
        padding: 6px;
        width: 100px;
        background-color: inherit;
        border: 2px solid gray;
    }

    .visitUser:hover{
        background-color: gray;
        color: #f7f7f7;
    }
</style>