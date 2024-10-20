package com.example.tuaojtmonitoringver1;

import androidx.annotation.NonNull;
import androidx.appcompat.app.ActionBarDrawerToggle;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.view.GravityCompat;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.appcompat.widget.Toolbar; // Correct import

import android.os.Bundle;
import android.view.MenuItem;
import android.widget.Toast;

import com.google.android.material.navigation.NavigationView;

public class MainActivity extends AppCompatActivity implements NavigationView.OnNavigationItemSelectedListener {

    private DrawerLayout drawerLayout;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Toolbar toolbar = findViewById(R.id.toolbar); // Use androidx.appcompat.widget.Toolbar
        setSupportActionBar(toolbar); // Corrected method name

        drawerLayout = findViewById(R.id.drawer_layout);
        NavigationView navigationView = findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);

        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawerLayout, toolbar, R.string.open_nav, R.string.close_nav);
        drawerLayout.addDrawerListener(toggle);
        toggle.syncState();

        if (savedInstanceState == null) {
            getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container_view, new aboutid()).commit();
            navigationView.setCheckedItem(R.id.nav_home);
        }
    }

    @Override
    public boolean onNavigationItemSelected(@NonNull MenuItem item) {
        int id = item.getItemId();

        if (id == R.id.nav_home) {
            getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container_view, new aboutid()).commit();
        } else if (id == R.id.nav_aboutid) {
            getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container_view, new aboutid()).commit();
        } else if (id == R.id.nav_subar) {
            getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container_view, new subar()).commit();
        } else if (id == R.id.nav_viewprogress) {
            getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container_view, new viewprogress()).commit();
        } else if (id == R.id.nav_logout) {
            getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container_view, new Logout()).commit();
            Toast.makeText(this, "Logged out", Toast.LENGTH_SHORT).show();
        }

        drawerLayout.closeDrawer(GravityCompat.START);
        return true;
    }


    @Override
    public void onBackPressed() {
        if (drawerLayout.isDrawerOpen(GravityCompat.START)) {
            drawerLayout.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }
}
