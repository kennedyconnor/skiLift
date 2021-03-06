import Vue from 'vue'
import Vuex from 'vuex'
import Axios from 'axios'
import router from './router'
import AuthService from './AuthService'
import MapService from './MapService'

Vue.use(Vuex)

let baseUrl = location.host.includes('localhost') ? '//localhost:5000/' : '/'

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000,
  withCredentials: true
})

export default new Vuex.Store({
  state: {
    user: {},
    activePassenger: {},
    activeRide: {},
    rides: [],
    passengers: [],
    activeMap: {}

  },

  mutations: {
    setUser(state, user) {
      state.user = user;
    },
    setActivePassenger(state, activePassenger) {
      state.activePassenger = activePassenger;
    },
    setActiveRide(state, activeRide) {
      state.activeRide = activeRide;
    },
    setRides(state, rides) {
      state.rides = rides;
    },
    setPassengers(state, passengers) {
      state.passengers = passengers;
    },
    setMap(state, activeMap) {
      state.activeMap = activeMap;
    },
    resetState(state) {
      state.user = {}
    }

  },

  actions: {
    //#region AUTH
    async register({ commit, dispatch }, creds) {
      try {
        let user = await AuthService.Register(creds)
        commit('setUser', user)
        router.push({ name: "home" })
      } catch (e) {
        console.warn(e.message)
      }
    },
    async login({ commit, dispatch }, creds) {
      try {
        let user = await AuthService.Login(creds)
        commit('setUser', user)
        router.push({ name: "home" })
      } catch (e) {
        console.warn(e.message)
      }
    },
    async logout({ commit, dispatch }) {
      try {
        let success = await AuthService.Logout()
        if (!success) { }
        commit('resetState')
        router.push({ name: "login" })
      } catch (e) {
        console.warn(e.message)
      }
    },
    //#endregion

    //#region RIDES
    async getAllRides({ commit, dispatch }) {
      try {
        let res = await api.get("rides");
        commit("setRides", res.data)
      } catch (error) {
        console.warn(error.message)
      }
    },

    async createRide({ commit, dispatch }, payload) {
      try {
        await api.post("rides", payload)
        dispatch("getAllRides")
      } catch (error) {
        console.warn(error.message)
      }
    },
    async editRide({ commit, dispatch }, payload) {
      try {
        await api.put("rides/" + payload.id, payload)
        dispatch("getAllRides")
      } catch (error) {
        console.warn(error.message)
      }
    },
    async deleteRide({ commit, dispatch }, id) {
      try {
        await api.delete("rides/" + id)
        dispatch("getAllRides")
      } catch (error) {
        console.warn(error.message)
      }
    },
    //#endregion

    //#region PASSENGERS
    async getAllPassengers({ commit, dispatch }) {
      try {
        let res = await api.get("passengers");
        commit("setPassengers", res.data)
      } catch (error) {
        console.warn(error.message)
      }
    },

    async createPassenger({ commit, dispatch }, payload) {
      try {
        await api.post("passengers", payload)
        dispatch("getAllPassengers")
      } catch (error) {
        console.warn(error.message)
      }
    },
    async editPassenger({ commit, dispatch }, payload) {
      try {
        await api.put("passengers/" + payload.id, payload)
        dispatch("getAllPassengers")
      } catch (error) {
        console.warn(error.message)
      }
    },
    async deletePassenger({ commit, dispatch }, id) {
      try {
        await api.delete("passengers/" + id)
        dispatch("getAllPassengers")
      } catch (error) {
        console.warn(error.message)
      }
    },
    //#endregion

    //#region RIDE-PASSENGERS
    async getAllRide_Passengers({ commit, dispatch }) {
      try {
        let res = await api.get("ride_passengers");
        commit("setRide_Passengers", res.data)
      } catch (error) {
        console.warn(error.message)
      }
    },

    async createRide_Passenger({ commit, dispatch }, payload) {
      try {
        await api.post("ride_passengers", payload)
        dispatch("getAllRide_Passengers")
      } catch (error) {
        console.warn(error.message)
      }
    },
    async editRide_Passenger({ commit, dispatch }, payload) {
      try {
        await api.put("ride_passengers/" + payload.id, payload)
        dispatch("getAllRide_Passengers")
      } catch (error) {
        console.warn(error.message)
      }
    },
    async deleteRide_Passenger({ commit, dispatch }, id) {
      try {
        await api.delete("ride_passengers/" + id)
        dispatch("getAllRide_Passengers")
      } catch (error) {
        console.warn(error.message)
        //#endregion
      }
    }
  }
})
