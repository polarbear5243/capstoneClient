S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 6904
Date: 2017-04-09 00:51:20+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6904, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb6d9f374
r2   = 0x0000005f, r3   = 0x00000065
r4   = 0xb77de7b0, r5   = 0xb6d9f374
r6   = 0xb76ec8e0, r7   = 0xb7827b00
r8   = 0x00000000, r9   = 0xb760a610
r10  = 0xb6e05eac, fp   = 0x00000000
ip   = 0xb5e9a1d8, sp   = 0xbec77ea0
lr   = 0xb5e856cd, pc   = 0xb66ab6f0
cpsr = 0xa0070030

Memory Information
MemTotal:   987012 KB
MemFree:    146704 KB
Buffers:     44052 KB
Cached:     335508 KB
VmPeak:     135512 KB
VmSize:     134248 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29536 KB
VmRSS:       28740 KB
VmData:      46236 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35796 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6904 TID = 6904
6904 6905 6965 6966 6974 

Maps Information
af12e000 af92d000 rw-p [stack:6974]
b0f23000 b0f34000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f44000 b0f49000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b134b000 b1353000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1365000 b1b64000 rw-p [stack:6966]
b1b64000 b1b65000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b75000 b1b89000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b9d000 b1b9e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bae000 b1bb1000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bc2000 b1bc3000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bd3000 b1bd5000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1be5000 b1be7000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bf7000 b1c07000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c17000 b1c23000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c35000 b2434000 rw-p [stack:6965]
b2765000 b276c000 r-xp /usr/lib/libefl-extension.so.0.1.0
b277f000 b2785000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2795000 b27b5000 r-xp /opt/usr/apps/org.example.client/bin/client
b28fe000 b29e1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a18000 b2a40000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a52000 b3251000 rw-p [stack:6905]
b3251000 b3253000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3263000 b326d000 r-xp /lib/libnss_files-2.20-2014.11.so
b327e000 b3287000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3298000 b32a9000 r-xp /lib/libnsl-2.20-2014.11.so
b32bc000 b32c2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32d3000 b32d4000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32fc000 b3303000 r-xp /usr/lib/libminizip.so.1.0.0
b3313000 b3318000 r-xp /usr/lib/libstorage.so.0.1
b3328000 b3387000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b339d000 b33b1000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33c1000 b3405000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3415000 b341d000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b342d000 b345d000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3470000 b3529000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b353d000 b3590000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35a1000 b35bc000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35cc000 b368d000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36a0000 b36b0000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36c0000 b36cd000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36de000 b36e5000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36f5000 b3736000 r-xp /usr/lib/libmdm.so.1.2.12
b3746000 b374e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b375d000 b376d000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b378e000 b37ee000 r-xp /usr/lib/libasound.so.2.0.0
b3800000 b3803000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3813000 b3816000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3826000 b382b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b383b000 b383c000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b384c000 b3857000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b386b000 b3872000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3882000 b3888000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3898000 b389d000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38ad000 b38c8000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38d8000 b38df000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38ef000 b38f2000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3903000 b3931000 r-xp /usr/lib/libidn.so.11.5.44
b3941000 b3957000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3968000 b3972000 r-xp /usr/lib/libcares.so.2.1.0
b3982000 b398c000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b399c000 b399e000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ae000 b39af000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39bf000 b39c3000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39d4000 b39fc000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a0d000 b3a36000 r-xp /usr/lib/libturbojpeg.so
b3a56000 b3a5c000 r-xp /usr/lib/libgif.so.4.1.6
b3a6c000 b3ab2000 r-xp /usr/lib/libcurl.so.4.3.0
b3ac3000 b3ae4000 r-xp /usr/lib/libexif.so.12.3.3
b3aff000 b3b14000 r-xp /usr/lib/libtts.so
b3b25000 b3b2d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b3d000 b3c03000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c23000 b3d1b000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d3a000 b3e08000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e1f000 b3e21000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e31000 b3e37000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e47000 b3e6a000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e7b000 b3e7d000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e8d000 b3e8f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ea0000 b3ea5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ebc000 b3ebe000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ece000 b3ed5000 r-xp /usr/lib/libsensord-share.so
b3ee5000 b3efd000 r-xp /usr/lib/libsensor.so.1.1.0
b3f0e000 b3f11000 r-xp /usr/lib/libXv.so.1.0.0
b3f21000 b3f26000 r-xp /usr/lib/libutilX.so.1.1.0
b3f36000 b3f3b000 r-xp /usr/lib/libappcore-common.so.1.1
b3f4b000 b3f52000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f65000 b3f69000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f7a000 b4058000 r-xp /usr/lib/libCOREGL.so.4.0
b4078000 b407b000 r-xp /usr/lib/libuuid.so.1.3.0
b408b000 b40a2000 r-xp /usr/lib/libblkid.so.1.1.0
b40b3000 b40b5000 r-xp /usr/lib/libXau.so.6.0.0
b40c5000 b410c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b411e000 b4124000 r-xp /usr/lib/libjson-c.so.2.0.1
b4135000 b4139000 r-xp /usr/lib/libogg.so.0.7.1
b4149000 b416b000 r-xp /usr/lib/libvorbis.so.0.4.3
b417b000 b425f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b427b000 b427e000 r-xp /usr/lib/libEGL.so.1.4
b428f000 b4295000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42a5000 b42a7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42b7000 b42c4000 r-xp /usr/lib/libGLESv2.so.2.0
b42d5000 b4337000 r-xp /usr/lib/libpixman-1.so.0.28.2
b434c000 b4364000 r-xp /usr/lib/libmount.so.1.1.0
b4376000 b438a000 r-xp /usr/lib/libxcb.so.1.1.0
b439a000 b43a1000 r-xp /lib/libcrypt-2.20-2014.11.so
b43d9000 b43db000 r-xp /usr/lib/libiri.so
b43eb000 b43f6000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4407000 b443d000 r-xp /usr/lib/libpulse.so.0.16.2
b444e000 b4491000 r-xp /usr/lib/libsndfile.so.1.0.25
b44a6000 b44bb000 r-xp /lib/libexpat.so.1.5.2
b44cd000 b458b000 r-xp /usr/lib/libcairo.so.2.11200.14
b459f000 b45a7000 r-xp /usr/lib/libdrm.so.2.4.0
b45b7000 b45ba000 r-xp /usr/lib/libdri2.so.0.0.0
b45ca000 b4618000 r-xp /usr/lib/libssl.so.1.0.0
b462d000 b4639000 r-xp /usr/lib/libeeze.so.1.13.0
b464a000 b4653000 r-xp /usr/lib/libethumb.so.1.13.0
b4663000 b4666000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4676000 b482d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5618000 b5621000 r-xp /usr/lib/libXi.so.6.1.0
b5631000 b5633000 r-xp /usr/lib/libXgesture.so.7.0.0
b5643000 b5647000 r-xp /usr/lib/libXtst.so.6.1.0
b5657000 b565d000 r-xp /usr/lib/libXrender.so.1.3.0
b566d000 b5673000 r-xp /usr/lib/libXrandr.so.2.2.0
b5683000 b5685000 r-xp /usr/lib/libXinerama.so.1.0.0
b5696000 b5699000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a9000 b56b4000 r-xp /usr/lib/libXext.so.6.4.0
b56c4000 b56c6000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d6000 b56d8000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e8000 b57ca000 r-xp /usr/lib/libX11.so.6.3.0
b57de000 b57e5000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f5000 b580d000 r-xp /usr/lib/libudev.so.1.6.0
b580f000 b5812000 r-xp /lib/libattr.so.1.1.0
b5822000 b5842000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5843000 b5848000 r-xp /usr/lib/libffi.so.6.0.2
b5859000 b5871000 r-xp /lib/libz.so.1.2.8
b5881000 b5883000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5893000 b5968000 r-xp /usr/lib/libxml2.so.2.9.2
b597d000 b5a18000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a34000 b5a37000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a47000 b5a60000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a71000 b5a82000 r-xp /lib/libresolv-2.20-2014.11.so
b5a96000 b5b10000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b25000 b5b27000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b37000 b5b3e000 r-xp /usr/lib/libembryo.so.1.13.0
b5b4e000 b5b58000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b69000 b5b81000 r-xp /usr/lib/libpng12.so.0.50.0
b5b92000 b5bb5000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bd6000 b5bea000 r-xp /usr/lib/libector.so.1.13.0
b5bfb000 b5c13000 r-xp /usr/lib/liblua-5.1.so
b5c24000 b5c7b000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c8f000 b5cb7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cc8000 b5cdb000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cec000 b5d26000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d37000 b5d45000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d55000 b5d5d000 r-xp /usr/lib/libtbm.so.1.0.0
b5d6d000 b5d7a000 r-xp /usr/lib/libeio.so.1.13.0
b5d8a000 b5d8c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d9c000 b5da1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5db1000 b5dc8000 r-xp /usr/lib/libefreet.so.1.13.0
b5dda000 b5dfa000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e0a000 b5e2a000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e2c000 b5e32000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e42000 b5e53000 r-xp /usr/lib/libemotion.so.1.13.0
b5e64000 b5e6b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e7b000 b5e8a000 r-xp /usr/lib/libeo.so.1.13.0
b5e9b000 b5ead000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ebe000 b5ec3000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ed3000 b5eec000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5efc000 b5f19000 r-xp /usr/lib/libeet.so.1.13.0
b5f32000 b5f7a000 r-xp /usr/lib/libeina.so.1.13.0
b5f8b000 b5f9b000 r-xp /usr/lib/libefl.so.1.13.0
b5fac000 b6091000 r-xp /usr/lib/libicuuc.so.51.1
b60ae000 b61ee000 r-xp /usr/lib/libicui18n.so.51.1
b6205000 b623d000 r-xp /usr/lib/libecore_x.so.1.13.0
b624f000 b6252000 r-xp /lib/libcap.so.2.21
b6262000 b628b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b629c000 b62a3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62b5000 b62ec000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62fd000 b63e8000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63fb000 b6474000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6486000 b648b000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b649b000 b64a5000 r-xp /usr/lib/libvconf.so.0.2.45
b64b5000 b64b7000 r-xp /usr/lib/libvasum.so.0.3.1
b64c7000 b64c9000 r-xp /usr/lib/libttrace.so.1.1
b64d9000 b64dc000 r-xp /usr/lib/libiniparser.so.0
b64ec000 b6512000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6522000 b6527000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6538000 b654f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6560000 b65cb000 r-xp /lib/libm-2.20-2014.11.so
b65dc000 b65e2000 r-xp /lib/librt-2.20-2014.11.so
b65f3000 b6600000 r-xp /usr/lib/libunwind.so.8.0.1
b6636000 b675a000 r-xp /lib/libc-2.20-2014.11.so
b676f000 b6788000 r-xp /lib/libgcc_s-4.9.so.1
b6798000 b687a000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b688b000 b68b5000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68c6000 b6902000 r-xp /usr/lib/libsystemd.so.0.4.0
b6904000 b6987000 r-xp /usr/lib/libedje.so.1.13.0
b699a000 b69b8000 r-xp /usr/lib/libecore.so.1.13.0
b69d8000 b6b5f000 r-xp /usr/lib/libevas.so.1.13.0
b6b94000 b6ba8000 r-xp /lib/libpthread-2.20-2014.11.so
b6bbc000 b6df0000 r-xp /usr/lib/libelementary.so.1.13.0
b6e1f000 b6e23000 r-xp /usr/lib/libsmack.so.1.0.0
b6e33000 b6e3a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e4a000 b6e4c000 r-xp /usr/lib/libdlog.so.0.0.0
b6e5c000 b6e5f000 r-xp /usr/lib/libbundle.so.0.1.22
b6e6f000 b6e71000 r-xp /lib/libdl-2.20-2014.11.so
b6e82000 b6e9a000 r-xp /usr/lib/libaul.so.0.1.0
b6eae000 b6eb3000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ec4000 b6ed1000 r-xp /usr/lib/liblptcp.so
b6ee3000 b6ee7000 r-xp /usr/lib/libsys-assert.so
b6ef8000 b6f18000 r-xp /lib/ld-2.20-2014.11.so
b6f29000 b6f2e000 r-xp /usr/bin/launchpad-loader
b744a000 b7878000 rw-p [heap]
bec58000 bec79000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6904)
Call Stack Count: 1
 0: (0xb66ab6f0) [/lib/libc.so.6] + 0x756f0
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
09+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb858a908
04-09 00:50:10.909+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:50:10.909+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:50:10.909+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:50:10.909+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:50:10.909+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:50:18.286+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7755485
04-09 00:50:18.707+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7755905
04-09 00:50:18.967+0900 W/cluster-view(  868): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-09 00:50:19.518+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7756711
04-09 00:50:19.728+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7756921
04-09 00:50:19.988+0900 W/cluster-view(  868): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-09 00:50:20.999+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7758193
04-09 00:50:21.079+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7758270
04-09 00:50:21.079+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-09 00:50:21.079+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-09 00:50:21.079+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-09 00:50:21.089+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:50:21.089+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:50:21.089+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:50:21.099+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:50:21.099+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:50:21.109+0900 I/abc     ( 6770): abc
04-09 00:50:21.109+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:50:21.109+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:50:21.139+0900 E/TBM     ( 6770): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:50:21.199+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6770, appid: org.example.client
04-09 00:50:21.199+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:50:21.209+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6770)
04-09 00:50:21.399+0900 D/basicui ( 6770): successed to load edc file
04-09 00:50:21.429+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:21.429+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:21.449+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:50:21.449+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:21.459+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:50:21.459+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:21.489+0900 I/MY_LOG  ( 6770): change
04-09 00:50:21.530+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(514) > [APP 6770] Event: RESET State: CREATED
04-09 00:50:21.530+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:50:21.540+0900 E/EFL     ( 6770): edje<6770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:21.540+0900 E/EFL     ( 6770): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:21.550+0900 E/EFL     ( 6770): edje<6770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:21.550+0900 E/EFL     ( 6770): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:21.550+0900 E/EFL     ( 6770): edje<6770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:21.550+0900 E/EFL     ( 6770): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:21.560+0900 W/APP_CORE( 6770): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-09 00:50:21.560+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:50:21.680+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:50:21.680+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:50:21.680+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:50:21.690+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:50:21.690+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:50:21.690+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:50:21.690+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(514) > [APP 6770] Event: RESUME State: CREATED
04-09 00:50:21.690+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6770) status(3)
04-09 00:50:21.690+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6770)
04-09 00:50:21.690+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6770, appid: org.example.client, status: fg
04-09 00:50:21.700+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:50:21.700+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:50:21.700+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:50:21.710+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:50:21.710+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(625) > [APP 6770] Initial Launching, call the resume_cb
04-09 00:50:21.710+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:50:22.050+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6770) status(0)
04-09 00:50:22.260+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.564
04-09 00:50:22.270+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:50:22.270+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6770.
04-09 00:50:23.021+0900 I/UXT     ( 6842): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:50:23.481+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7760669
04-09 00:50:23.562+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7760757
04-09 00:50:23.622+0900 D/basicui ( 6770): successed to load edc file
04-09 00:50:23.642+0900 I/MY_LOG  ( 6770): change
04-09 00:50:23.652+0900 I/MY_LOG  ( 6770): change
04-09 00:50:23.672+0900 I/MY_LOG  ( 6770): change
04-09 00:50:24.593+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7761787
04-09 00:50:24.603+0900 I/MY_LOG  ( 6770): Button pressed
04-09 00:50:24.693+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7761886
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6770) : db/ise/keysound error
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:50:24.753+0900 I/MY_LOG  ( 6770): Button unpressed
04-09 00:50:24.843+0900 E/EFL     ( 6770): elementary<6770> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:50:26.695+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-09 00:50:27.045+0900 W/CRASH_MANAGER( 6784): worker.c: worker_job(1199) > 1106770636c691491666626
04-09 00:50:27.075+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6770 pgid = 6770
04-09 00:50:27.075+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(6770)
04-09 00:50:27.075+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:27.135+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:50:27.135+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:50:27.135+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:50:27.135+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:50:27.135+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:50:27.135+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:50:27.165+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:27.165+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:50:27.165+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:50:27.165+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:50:27.165+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:50:27.165+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:50:27.165+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:50:27.175+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 6770
04-09 00:50:27.175+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[6770] terminate event is forwarded
04-09 00:50:27.175+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:50:27.175+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 6770, ]
04-09 00:50:27.175+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:50:27.175+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:50:27.175+0900 I/Tizen::App( 1246): (512) > Not registered pid(6770)
04-09 00:50:27.175+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:50:27.175+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:27.175+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6770
04-09 00:50:27.175+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6770
04-09 00:50:27.175+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.568
04-09 00:50:27.195+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:50:27.195+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:27.195+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 6770.
04-09 00:50:27.275+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:50:27.285+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:27.285+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:50:27.285+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:27.305+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-09 00:50:27.305+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:50:27.305+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-09 00:50:27.305+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:50:27.305+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:50:27.305+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:50:27.365+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb8531da8]
04-09 00:50:27.365+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-09 00:50:27.365+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb8531da8
04-09 00:50:27.375+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:50:27.375+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:50:27.375+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:50:27.375+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:50:27.375+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:31.229+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:50:35.613+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7772805
04-09 00:50:35.703+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7772893
04-09 00:50:35.703+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-09 00:50:35.703+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-09 00:50:35.703+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-09 00:50:35.713+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:50:35.713+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:50:35.723+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:50:35.723+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:50:35.723+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:50:35.733+0900 I/abc     ( 6842): abc
04-09 00:50:35.733+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:50:35.733+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:50:35.763+0900 E/TBM     ( 6842): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:50:35.823+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6842, appid: org.example.client
04-09 00:50:35.823+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:50:35.833+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6842)
04-09 00:50:36.014+0900 D/basicui ( 6842): successed to load edc file
04-09 00:50:36.054+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:36.054+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:36.064+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:50:36.064+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:36.074+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:36.084+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:50:36.104+0900 I/MY_LOG  ( 6842): change
04-09 00:50:36.154+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(514) > [APP 6842] Event: RESET State: CREATED
04-09 00:50:36.154+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:50:36.164+0900 E/EFL     ( 6842): edje<6842> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:36.164+0900 E/EFL     ( 6842): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:36.164+0900 E/EFL     ( 6842): edje<6842> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:36.164+0900 E/EFL     ( 6842): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:36.174+0900 E/EFL     ( 6842): edje<6842> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:36.174+0900 E/EFL     ( 6842): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:36.174+0900 W/APP_CORE( 6842): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-09 00:50:36.174+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:50:36.304+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:50:36.304+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:50:36.304+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:50:36.304+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(514) > [APP 6842] Event: RESUME State: CREATED
04-09 00:50:36.304+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:50:36.304+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:50:36.304+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:50:36.304+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6842) status(3)
04-09 00:50:36.314+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6842)
04-09 00:50:36.314+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6842, appid: org.example.client, status: fg
04-09 00:50:36.324+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:50:36.324+0900 I/APP_CORE( 6842): appcore-efl.c: __do_app(625) > [APP 6842] Initial Launching, call the resume_cb
04-09 00:50:36.324+0900 I/CAPI_APPFW_APPLICATION( 6842): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:50:36.324+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:50:36.324+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:50:36.324+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:50:36.664+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6842) status(0)
04-09 00:50:36.864+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:50:36.864+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6842.
04-09 00:50:36.875+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.570
04-09 00:50:37.635+0900 I/UXT     ( 6904): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:50:38.016+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7775199
04-09 00:50:38.096+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7775287
04-09 00:50:39.087+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7776272
04-09 00:50:39.177+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7776371
04-09 00:50:39.227+0900 D/basicui ( 6842): successed to load edc file
04-09 00:50:39.257+0900 I/MY_LOG  ( 6842): change
04-09 00:50:39.257+0900 I/MY_LOG  ( 6842): change
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6842) : db/ise/keysound error
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:50:39.277+0900 E/VCONF   ( 6842): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:50:39.317+0900 I/MY_LOG  ( 6842): change
04-09 00:50:40.208+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7777402
04-09 00:50:40.208+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:50:40.278+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7777468
04-09 00:50:40.278+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:50:40.358+0900 E/EFL     ( 6842): elementary<6842> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:50:41.309+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-09 00:50:43.371+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7780559
04-09 00:50:43.951+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7781146
04-09 00:50:48.326+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7785508
04-09 00:50:48.326+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:50:48.406+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7785596
04-09 00:50:48.406+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:50:48.496+0900 D/basicui ( 6842): successed to load edc file
04-09 00:50:48.506+0900 I/MY_LOG  ( 6842): change
04-09 00:50:50.117+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7787302
04-09 00:50:50.428+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7787612
04-09 00:50:52.159+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7789334
04-09 00:50:52.219+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7789411
04-09 00:50:53.411+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7790605
04-09 00:50:53.491+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7790682
04-09 00:50:54.221+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7791411
04-09 00:50:54.302+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7791488
04-09 00:50:54.952+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7792142
04-09 00:50:55.353+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7792540
04-09 00:50:56.023+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7793209
04-09 00:50:56.364+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7793529
04-09 00:50:57.074+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7794254
04-09 00:50:57.144+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7794331
04-09 00:50:58.035+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7795222
04-09 00:50:58.125+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7795310
04-09 00:50:59.587+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7796777
04-09 00:50:59.587+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:50:59.667+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7796854
04-09 00:50:59.667+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:50:59.687+0900 E/EFL     ( 6842): elementary<6842> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:50:59.997+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-09 00:51:00.007+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:51
04-09 00:51:00.007+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오전 12:51"
04-09 00:51:00.007+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:51"
04-09 00:51:00.007+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-09 00:51:00.007+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145476264 Time: <font_size=31> </font_size> <font_size=31> 오전 12:51</font_size></font>"
04-09 00:51:01.338+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7798530
04-09 00:51:01.438+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7798629
04-09 00:51:01.489+0900 D/basicui ( 6842): successed to load edc file
04-09 00:51:01.509+0900 I/MY_LOG  ( 6842): change
04-09 00:51:01.509+0900 I/MY_LOG  ( 6842): change
04-09 00:51:01.529+0900 I/MY_LOG  ( 6842): change
04-09 00:51:02.510+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7799705
04-09 00:51:02.510+0900 I/MY_LOG  ( 6842): Button pressed
04-09 00:51:02.600+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7799792
04-09 00:51:02.600+0900 I/MY_LOG  ( 6842): Button unpressed
04-09 00:51:02.680+0900 E/EFL     ( 6842): elementary<6842> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:51:03.641+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7800837
04-09 00:51:03.751+0900 E/EFL     ( 6842): ecore_x<6842> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7800947
04-09 00:51:03.991+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:04.011+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:51:04.011+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:51:04.011+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:51:04.011+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:51:04.011+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:51:04.021+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:51:04.031+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6842 pgid = 6842
04-09 00:51:04.031+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(6842)
04-09 00:51:04.061+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:51:04.061+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:04.061+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:51:04.061+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:51:04.071+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:51:04.071+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:51:04.071+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:51:04.071+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[6842] terminate event is forwarded
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 6842, ]
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:51:04.071+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:51:04.071+0900 I/Tizen::App( 1246): (512) > Not registered pid(6842)
04-09 00:51:04.071+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:51:04.071+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:04.071+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 6842
04-09 00:51:04.071+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6842
04-09 00:51:04.071+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6842
04-09 00:51:04.081+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.574
04-09 00:51:04.091+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:04.091+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 6842.
04-09 00:51:04.101+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:51:04.101+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:51:04.111+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:04.141+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-09 00:51:04.141+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:51:04.141+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-09 00:51:04.141+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:51:04.151+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:51:04.151+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:51:04.171+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7801362
04-09 00:51:04.181+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:51:04.181+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:04.181+0900 W/CRASH_MANAGER( 6913): worker.c: worker_job(1199) > 1106842636c691491666663
04-09 00:51:04.261+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7801448
04-09 00:51:04.281+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb8430a10]
04-09 00:51:04.281+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-09 00:51:04.281+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb8430a10
04-09 00:51:04.281+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:51:04.281+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:51:04.281+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:51:04.281+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:51:04.281+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:51:16.133+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7813318
04-09 00:51:16.173+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7813362
04-09 00:51:16.173+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-09 00:51:16.173+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-09 00:51:16.183+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-09 00:51:16.193+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:51:16.193+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:51:16.193+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:51:16.193+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:51:16.193+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:51:16.203+0900 I/abc     ( 6904): abc
04-09 00:51:16.203+0900 I/CAPI_APPFW_APPLICATION( 6904): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:51:16.203+0900 I/CAPI_APPFW_APPLICATION( 6904): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:51:16.233+0900 E/TBM     ( 6904): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:51:16.293+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6904, appid: org.example.client
04-09 00:51:16.293+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:51:16.293+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6904)
04-09 00:51:16.493+0900 D/basicui ( 6904): successed to load edc file
04-09 00:51:16.523+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:16.523+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:51:16.533+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:51:16.533+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:51:16.543+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:51:16.553+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:51:16.573+0900 I/MY_LOG  ( 6904): change
04-09 00:51:16.623+0900 I/APP_CORE( 6904): appcore-efl.c: __do_app(514) > [APP 6904] Event: RESET State: CREATED
04-09 00:51:16.623+0900 I/CAPI_APPFW_APPLICATION( 6904): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:51:16.633+0900 E/EFL     ( 6904): edje<6904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:51:16.633+0900 E/EFL     ( 6904): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:51:16.633+0900 E/EFL     ( 6904): edje<6904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:51:16.633+0900 E/EFL     ( 6904): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:51:16.643+0900 E/EFL     ( 6904): edje<6904> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:51:16.643+0900 E/EFL     ( 6904): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:51:16.643+0900 W/APP_CORE( 6904): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-09 00:51:16.643+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:51:16.773+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:51:16.773+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:51:16.773+0900 I/APP_CORE( 6904): appcore-efl.c: __do_app(514) > [APP 6904] Event: RESUME State: CREATED
04-09 00:51:16.773+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:51:16.773+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:51:16.773+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:51:16.773+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:51:16.783+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6904) status(3)
04-09 00:51:16.783+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6904)
04-09 00:51:16.783+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6904, appid: org.example.client, status: fg
04-09 00:51:16.793+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:51:16.793+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:51:16.793+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:51:16.803+0900 I/APP_CORE( 6904): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:51:16.803+0900 I/APP_CORE( 6904): appcore-efl.c: __do_app(625) > [APP 6904] Initial Launching, call the resume_cb
04-09 00:51:16.803+0900 I/CAPI_APPFW_APPLICATION( 6904): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:51:17.134+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6904) status(0)
04-09 00:51:17.334+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:51:17.334+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6904.
04-09 00:51:17.344+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.577
04-09 00:51:18.115+0900 I/UXT     ( 6971): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:51:19.026+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7816209
04-09 00:51:19.096+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7816286
04-09 00:51:19.146+0900 D/basicui ( 6904): successed to load edc file
04-09 00:51:19.166+0900 I/MY_LOG  ( 6904): change
04-09 00:51:19.176+0900 I/MY_LOG  ( 6904): change
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6904) : db/ise/keysound error
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:51:19.196+0900 E/VCONF   ( 6904): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:51:19.236+0900 I/MY_LOG  ( 6904): change
04-09 00:51:19.987+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7817180
04-09 00:51:19.987+0900 I/MY_LOG  ( 6904): Button pressed
04-09 00:51:20.067+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7817257
04-09 00:51:20.067+0900 I/MY_LOG  ( 6904): Button unpressed
04-09 00:51:20.157+0900 E/EFL     ( 6904): elementary<6904> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:51:20.747+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7817942
04-09 00:51:20.847+0900 E/EFL     ( 6904): ecore_x<6904> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7818041
04-09 00:51:21.058+0900 W/CRASH_MANAGER( 6913): worker.c: worker_job(1199) > 1106904636c69149166668
