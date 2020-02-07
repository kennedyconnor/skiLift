<template>
  <div class="logout ">
    <button class="btn btn-warning" @click="logout()"> Log out bro</button>
  </div>
</template>

<script>
  export default {
    name: "logout",
    props: [],
    data() {
      return {}
    },
    computed: {},
    methods: {
      logout() {
        this.$store.dispatch("logout")
      }
    },
    components: {}
  }
</script>

<style>

</style>