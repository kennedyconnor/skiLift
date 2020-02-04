<template>
  <div class="passengerForm col-4">
    <h3>Passenger</h3>
    <h5>Find a ride</h5>
    <form>
      <div class="form-group">
        <label>Destination (Idaho)</label>
        <select class="form-control" id="PassengerFormDestinationSelect" v-model="destination">
          <option>Bogus Basin</option>
          <option>Tamarack</option>
          <option>Brundage</option>
          <option>Sun Valley</option>
        </select>
      </div>
      <button class="btn btn-primary" @click="createPassenger()">Go</button>
    </form>
  </div>
</template>

<script>
  export default {
    name: "passengerForm",
    props: [],
    data() {
      return {
        destination: ""
      }
    },
    computed: {},
    methods: {
      createPassenger() {
        let newPassenger = {
          name: "Connor"//this.store.state.user.name
          ,
          destination: this.destination
        }
        this.$store.dispatch("createPassenger", newPassenger)
      }
    },
    components: {}
  }
</script>

<style>

</style>