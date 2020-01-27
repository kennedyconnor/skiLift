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
      return {}
    },
    computed: {},
    methods: {},
    components: {}
  }
</script>

<style>

</style>