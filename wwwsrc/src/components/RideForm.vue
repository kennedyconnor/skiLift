<template>
  <div class="rideForm col-4 offset-2">
    <h3>Driver</h3>
    <h5>Pick up passengers</h5>
    <form>
      <div class="form-group">
        <label>Destination (Idaho)</label>
        <select class="form-control" id="RideFormDestinationSelect">
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
    name: "",
    props: [],
    data() {
      return {
        ride: {
          destination: "",
          capacity: 0,
        }
      }
    },
    computed: {},
    methods: {
      createRide() {
        let newRide = this.ride
        newRide.name = this.store.state.user.name
        newRide.destination = this.ride.destination
        newRide.capaity = this.ride.capacity
        this.store.dispatch("createRide", newRide)
      }
    },
    components: {}
  }
</script>

<style>

</style>