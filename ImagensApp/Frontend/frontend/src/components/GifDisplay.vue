<template>
    <div>
      <h2>Search Results</h2>
      <div v-if="gifs.length === 0">No GIFs found.</div>
      <div v-else>
        <div v-for="gif in gifs" :key="gif.id">
          <img :src="gif.url" :alt="gif.title">
        </div>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    props: ['gifs'], // Receive GIF data as a prop from the parent component
  };
  </script>
  
  <style scoped>
  /* Add any CSS styles specific to this component */
  </style>
  