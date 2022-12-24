<template>
    <div class="login">
      <h1 id="welcome">Welcome to Event App</h1>
      <div v-if="ops=='signin'" class="signin">
        <div class="signinInfo" style="background-color: inherit; margin-left: auto; margin-right: auto;">
          <p style="background-color: inherit; color: #f7f7f7; font-size: 30px; font-weight: bolder; align-self: flex-start;">Username: </p>
          <br>
          <input type="text" name="username" id="username" size="50" height="50" style="background-color: #f7f7f7; border: none; height: 30px; margin: auto;">
          <br><br><br>
          <p style="background-color: inherit; color: #f7f7f7; font-size: 30px; font-weight: bolder;  align-self: flex-start;">Password: </p>
          <br>
          <input type="password" name="password" id="password" size="50" height="50" style="background-color: #f7f7f7; border: none; height: 30px; margin: auto;">
          <br><br><br>
          <button class="enterButton" style="border: none;  display: inline; width: 200px; height: auto; padding: 3px; font-size: 25px;  font-weight: bold;">Sign In</button>
        </div>

        <div class="createAccount" style="background-color: inherit;">
          <p style="background-color: #3BCF4A; color: #f7f7f7; font-size: 30px; font-weight: bold; display: inline; ">Don't you have an account?</p> <button  class="enterButton" style="border: none;  display: inline; width: 200px; height: auto; padding: 3px; font-size: 25px;  font-weight: bold; align-self: flex-end;" @click="ops='signup'" >Sign Up</button>
        </div>
      </div>

      <div v-if="ops=='signup'" class="signup">
        <div class="signinInfo1" style="background-color: inherit; margin-left: auto; margin-right: auto;">
          
          <div class="form">
            <p style="background-color: inherit; color: #f7f7f7; font-size: 30px; font-weight: bolder; align-self: flex-start;">Name: </p>
            <br>
            <input type="text" name="name" id="name" size="50" height="50" style="background-color: #f7f7f7; border: none; height: 30px; margin: auto;">
          </div>

          <div class="form">
            <p style="background-color: inherit; color: #f7f7f7; font-size: 30px; font-weight: bolder;  align-self: flex-start;">Surname: </p>
            <br>
            <input type="text" name="surname" id="surname" size="50" height="50" style="background-color: #f7f7f7; border: none; height: 30px; margin: auto;">
          </div>

          <div class="form" style="align-self: flex-start;">
            <p style="background-color: inherit; color: #f7f7f7; font-size: 30px; font-weight: bolder;  align-self: flex-start;">Birthdate: </p>
            <br>
            <input type="date" name="birth" id="birth" size="50" height="50" style="background-color: #f7f7f7; border: none; height: 30px; margin: auto;">
          </div>

          <div class="form" style="align-self: flex-start;">
            <p style="background-color: inherit; color: #f7f7f7; font-size: 30px; font-weight: bolder;  align-self: flex-start;">Gender: </p>
            <br>
              <input type="radio" name="gender" id="male" value="male" style="height: 20px; width: 20px;"><span style="color: #f7f7f7; font-size: 23px; margin: 10px; margin-right: 20px;">Male</span>
              <input type="radio" name="gender" id="female" value="female" style="height: 20px; width: 20px;"><span style="color: #f7f7f7; font-size: 23px; margin: 10px; margin-right: 20px;">Female</span>
           
          </div>
        </div>
        <div class="signinInfo2" style="background-color: inherit; margin-left: auto; margin-right: auto;">
          <div class="form">
            <p style="background-color: inherit; color: #f7f7f7; font-size: 30px; font-weight: bolder; align-self: flex-start;">Username: </p>
            <br>
            <input type="text" name="username" id="username" size="50" height="50" style="background-color: #f7f7f7; border: none; height: 30px; margin: auto;">
          </div>

          <div class="form">
            <p style="background-color: inherit; color: #f7f7f7; font-size: 30px; font-weight: bolder;  align-self: flex-start;">Password: </p>
            <br>
            <input type="password" name="password" id="password" size="50" height="50" style="background-color: #f7f7f7; border: none; height: 30px; margin: auto;">
          </div>

          <div class="form" style="align-self: flex-start;">
            <p style="background-color: inherit; color: #f7f7f7; font-size: 30px; font-weight: bolder;  align-self: flex-start;">About Yourself: </p>
            <br>
            <textarea name="about" id="about" cols="40" rows="5" placeholder="Write something about yourself..." style="background-color: #f7f7f7; resize: none; padding: 6px; font-size: 18px;" ></textarea>
          </div>
          <div class="form">
            <button class="enterButton" style="border: none;  display: inline; width: 200px; height: auto; padding: 3px; font-size: 25px;  font-weight: bold; align-self: flex-end; margin-right: 15px;" @click="ops='signin'" >Go Back</button>
          <button class="enterButton" style="border: none;  display: inline; width: 200px; height: auto; padding: 3px; font-size: 25px;  font-weight: bold; align-self: flex-end; margin-left: 15px;">Sign In</button>
          </div>
          
        </div>
      </div>
      
    </div>
</template>

<script>
export default{
    data(){
        return{
            ops:"signin",
        }
    },
}
</script>

<style>
  .login{
    display: flex;
    flex-direction: column;
    width: 100%;
    height: 100%;
    justify-content: center;
    align-items: center;
    padding: auto;
  }

  #welcome{
    margin: 20px;
    color: #ffffff;
    font-size: 50px;
    text-align: center;
  }
  .signin{
    width: 65%;
    height: 500px;
    background-color: #3BCF4A;
    border-radius: 1%;
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: space-around;
  }

  .form{
    background-color: inherit;
    margin-top: 8px;
    margin-bottom: 8px;
  }

  .signup{
    width: 65%;
    height: 500px;
    background-color: #3BCF4A;
    border-radius: 1%;
    display: flex;
    
    align-items: flex-start;
    justify-content: space-between;
  }

  .signinInfo1{
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
  .signinInfo2{
    display: flex;
    flex-direction: column;
    justify-content: flex-start;
    align-items: flex-start;
  }

  .enterButton:hover{
    background-color: gray;
    color: #f7f7f7;
  }

  .enterButton{
    background-color: #f7f7f7;
    color: rgb(102, 102, 102);
  }

</style>