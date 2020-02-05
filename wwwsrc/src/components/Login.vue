<template>
  <div class="login">
    <!-- Button trigger modal -->
    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
      Login
    </button>

    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel"
      aria-hidden="true">
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-body">
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
            <br>
            <br>
            <form v-if="loginForm" @submit.prevent="login">
              <input type="email" v-model="creds.email" placeholder="email">
              <input type="password" v-model="creds.password" placeholder="password">
              <button type="submit">Login</button>
            </form>
            <form v-else @submit.prevent="register">
              <input type="text" v-model="newUser.username" placeholder="name">
              <input type="email" v-model="newUser.email" placeholder="email">
              <input type="password" v-model="newUser.password" placeholder="password">
              <button type="submit">Create Account</button>
            </form>
            <br>
            <div @click="loginForm = !loginForm">
              <p v-if="loginForm">Click to Register</p>
              <p v-else>Click to Login</p>
            </div>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>

          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    name: "login",
    props: [],
    data() {
      return {
        loginForm: true,
        creds: {
          email: "",
          password: ""
        },
        newUser: {
          email: "",
          password: "",
          username: ""
        }
      }
    },
    computed: {},
    methods: {
      register() {
        this.$store.dispatch("register", this.newUser);
      },
      login() {
        this.$store.dispatch("login", this.creds);
      }
    },
    components: {}
  }
</script>

<style>

</style>