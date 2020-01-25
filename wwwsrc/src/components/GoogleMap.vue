<template>
   <div class="Map">
      <div id="googleMap">

      </div>
   </div>
</template>

<script>
   export default {
      name: "GoogleMap",
      props: [],
      data() {
         return {
            gMap: "",
         }
      },
      computed: {},
      methods: {},
      components: {},
      mounted() {
         let latling = new google.maps.LatLng(43.6150, 116.2023)
         this.map = new google.maps.Map(document.getElementById('googleMap'), {
            center: { lat: 61.180059, lng: -149.822075 },
            scrollwheel: false,
            zoom: 4
         })
         console.log("map: ", this.gMap)
      }
   }
</script>

<style>
   #googleMap {
      height: 300px;
      width: 100%;
   }
</style>