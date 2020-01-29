<template>
  <div class="passengerForm col-4">
    <h3>Passenger</h3>
    <h5>Find a ride</h5>
    <form>
      <div class="form-group">
        <label>Destination (Idaho)</label>
        <select class="form-control" id="PassengerFormDestinationSelect">
          <option>Bogus Basin</option>
          <option>Tamarack</option>
          <option>Brundage</option>
          <option>Sun Valley</option>
        </select>
      </div>
    </form>
  </div>
</template>

<script>
  export default {
    name: "passengerForm",
    props: [],
    data() {
      return {
        passenger: {
          name: "",
          destination: "",
        }
      }
    },
    computed: {},
    methods: {
      createPassenger() {
        let newPassenger = this.passenger
        newPassenger.name = this.store.state.user.name
        newPassenger.destination = this.passenger.destination
        this.store.dispatch("createPassenger", newPassenger)
      }
    },
    components: {}
  }
</script>

<style>

</style>