<template>
   <div class="map">

   </div>
</template>

<script>
   export default {
      name: "map",
      props: [],
      data() {
         return {}
      },
      computed: {},
      methods: {},
      components: {},
      mounted() {
         console.log("map: ", google.maps)
         this.map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: 43.6150, lng: 116.2023 },
            scrollwheel: false,
            zoom: 4
         })
      }
   }
</script>

<style>
   #map {
      height: 300px;
      width: 100%;
   }
</style>