<template>
    own
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
                SADECE KULLANICININ CONTENTLERİ GETİRELECEK
            -->
            <!-- 
                v-for ile verileri yolla her bir veriyi content componentinin içine 
                parametre olarak yolla.
                Component parametreye göre verileri listelesin.
            -->
            </div>  
        </div>
        <div class="friend-list">
            <friend-list></friend-list>
        </div>
    </div>
</template>

<script>

</script>

<style>

</style>