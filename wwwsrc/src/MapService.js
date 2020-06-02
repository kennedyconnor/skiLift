
export default class MapService {
  static generateMap() {

  }
  static drawPassengers() {
    let marker = new google.maps.Marker({
      position: this.Connor,
      map: this.map,
      title: "Connor Kennedy",
      icon: {
        url: "ski.png", // url
        scaledSize: new google.maps.Size(30, 30),
      },
      //label: "Connor Kennedy"
    })

    let contentString = '<div id="content">' +
      '<div id="bodyContent">' +
      '<ul>Name: Connor Kennedy</ul>' +
      '<ul>Destination: Bogus Basin</ul>' +
      '</div>' +
      '</div>';

    let infoWindow = new google.maps.InfoWindow({
      content: contentString
    })
    marker.addListener('click', function () {
      infoWindow.open(this.map, marker);
    });
  }
}