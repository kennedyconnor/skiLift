<template>
  <div class="home ">
    <div class="row">
      <div class="col">
        <h3>SkiLift</h3>
        <h6>Easy ridesharing to your local mountain!</h6>
        <GoogleMap />
      </div>
    </div>
    <div class="row">
      <RideForm />
      <PassengerForm />
    </div>
    Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a
      href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>
  </div>
</template>


<script>
  import GoogleMap from "@/components/GoogleMap.vue"
  import RideForm from "@/components/RideForm.vue"
  import PassengerForm from "@/components/PassengerForm.vue"
  export default {
    name: "home",
    props: [],
    data() {
      return {}
    },
    computed: {},
    methods: {},
    components: { GoogleMap, RideForm, PassengerForm }
  }
</script>

<style>

</style>