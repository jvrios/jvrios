<template>
    <div>
      <input type="text" v-model="query" placeholder="Search GIFs...">
      <button @click="search">Search</button>
    </div>
  </template>
  
  <script>
import axios from 'axios'; // Import Axios for making HTTP requests

export default {
  data() {
    return {
      query: '', // To store the user's search query
      error: null, // To store any error message
    };
  },
  methods: {
    async search() {
      try {
        // Send a GET request to your backend API's search endpoint
        const response = await axios.get(`/api/giphy/search?query=${this.query}`);
        
        // Handle the response here
        console.log('Search Results:', response.data);
        // Emit an event with the search results
        this.$emit('search', response.data);
      } catch (error) {
        // Handle any errors here
        console.error('Error:', error);
        this.error = 'An error occurred while fetching GIFs. Please try again later.';
      }
    }
  }
};
</script>

  
  <style scoped>
  /* Add any CSS styles specific to this component */
  </style>
  