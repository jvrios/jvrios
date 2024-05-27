<template>
  <div>
    <input type="text" v-model="query" placeholder="Search GIFs...">
    <button @click="search">Search</button>
    <div v-if="loading">Loading...</div>
    <div v-if="error">{{ error }}</div>
    <div v-if="gifs.length > 0">
      <h2>Search Results</h2>
      <div class="gif-item" v-for="gif in gifs" :key="gif.id">
        <img :src="gif.images.original.url" :alt="gif.title">
      </div>
    </div>
  </div>
</template>

<script>
import GiphyService from '@/Services/GiphyService'; // Ensure the case matches the directory name

export default {
  data() {
    return {
      query: '', // To store the user's search query
      loading: false, // To indicate whether the search is in progress
      error: null, // To store any error message
      gifs: [], // To store the GIF data received from the backend
    };
  },
  methods: {
    async search() {
      this.loading = true; // Set loading to true when search begins
      this.error = null; // Reset error message
      try {
        // Send a GET request to search GIFs
        const data = await GiphyService.searchGifs(this.query); // Corrected method call
        
        // Update the GIFs data with the search results
        this.gifs = data.data; // Access data property of response
      } catch (error) {
        // Handle specific errors
        console.error('Error:', error);
        this.error = 'An error occurred while fetching GIFs. Please try again later.';
      } finally {
        this.loading = false; // Set loading to false when search is complete (success or error)
      }
    }
  }
};
</script>

<style scoped>
/* Add any CSS styles specific to this component */
.gif-item {
  margin-bottom: 20px;
}
</style>
