<template>
  <div class="home" id="home">
    <div class="row">
      <div class="col">
        <h3>SkiLift</h3>
        <h6>Easy ridesharing to your local mountain!</h6>
        <div v-if="!user.id">
          <Login />
        </div>
        <GoogleMap />
      </div>
    </div>
    <br>
    <div class="row">
      <RideForm />
      <PassengerForm />
    </div>
    <div class="page-footer">
      Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a
        href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>
    </div>
  </div>
</template>


<script>
  import GoogleMap from "@/components/GoogleMap.vue"
  import RideForm from "@/components/RideForm.vue"
  import PassengerForm from "@/components/PassengerForm.vue"
  import Login from "@/components/Login.vue"
  export default {
    name: "home",
    props: [],
    data() {
      return {}
    },
    computed: {
      user() { return this.$store.state.user }
    },
    methods: {},
    components: { GoogleMap, RideForm, PassengerForm, Login }
  }
</script>

<style>

</style>