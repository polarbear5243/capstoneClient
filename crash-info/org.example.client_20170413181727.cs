S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 26809
Date: 2017-04-13 18:17:27+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 26809, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000068b9
r2   = 0x00000006, r3   = 0xb405c4c0
r4   = 0x00000002, r5   = 0xb405c000
r6   = 0xb675609c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5e84708
r10  = 0xb8ea7188, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbefd1a64
lr   = 0xb664cf18, pc   = 0xb664bb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     55964 KB
Buffers:     66852 KB
Cached:     355508 KB
VmPeak:     134448 KB
VmSize:     133408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27924 KB
VmRSS:       27588 KB
VmData:      45540 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35732 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 26809 TID = 26809
26809 26810 26875 26876 26884 

Maps Information
af12e000 af92d000 rw-p [stack:26884]
b131f000 b1327000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1339000 b1b38000 rw-p [stack:26876]
b1b38000 b1b39000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b49000 b1b5d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b71000 b1b72000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b82000 b1b85000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b96000 b1b97000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1ba7000 b1ba9000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bb9000 b1bbb000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bcb000 b1bdb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1beb000 b1bf7000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c09000 b2408000 rw-p [stack:26875]
b2739000 b2740000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2753000 b2759000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2769000 b278f000 r-xp /opt/usr/apps/org.example.client/bin/client
b28e8000 b29cb000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a02000 b2a2a000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a3c000 b323b000 rw-p [stack:26810]
b323b000 b323d000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b324d000 b3257000 r-xp /lib/libnss_files-2.20-2014.11.so
b3268000 b3271000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3282000 b3293000 r-xp /lib/libnsl-2.20-2014.11.so
b32a6000 b32ac000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32bd000 b32be000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32e6000 b32ed000 r-xp /usr/lib/libminizip.so.1.0.0
b32fd000 b3302000 r-xp /usr/lib/libstorage.so.0.1
b3312000 b3371000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3387000 b339b000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33ab000 b33ef000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33ff000 b3407000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3417000 b3447000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b345a000 b3513000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3527000 b357a000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b358b000 b35a6000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35b6000 b3677000 r-xp /usr/lib/libprotobuf.so.9.0.1
b368a000 b369a000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36aa000 b36b7000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36c8000 b36cf000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36df000 b3720000 r-xp /usr/lib/libmdm.so.1.2.12
b3730000 b3738000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3747000 b3757000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3778000 b37d8000 r-xp /usr/lib/libasound.so.2.0.0
b37ea000 b37ed000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37fd000 b3800000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3810000 b3815000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3825000 b3826000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3836000 b3841000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3855000 b385c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b386c000 b3872000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3882000 b3887000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3897000 b38b2000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38c2000 b38c9000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38d9000 b38dc000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38ed000 b391b000 r-xp /usr/lib/libidn.so.11.5.44
b392b000 b3941000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3952000 b395c000 r-xp /usr/lib/libcares.so.2.1.0
b396c000 b3976000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3986000 b3988000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3998000 b3999000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39a9000 b39ad000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39be000 b39e6000 r-xp /usr/lib/libui-extension.so.0.1.0
b39f7000 b3a20000 r-xp /usr/lib/libturbojpeg.so
b3a40000 b3a46000 r-xp /usr/lib/libgif.so.4.1.6
b3a56000 b3a9c000 r-xp /usr/lib/libcurl.so.4.3.0
b3aad000 b3ace000 r-xp /usr/lib/libexif.so.12.3.3
b3ae9000 b3afe000 r-xp /usr/lib/libtts.so
b3b0f000 b3b17000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b27000 b3bed000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c0d000 b3d05000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d24000 b3df2000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e09000 b3e0b000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e1b000 b3e21000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e31000 b3e54000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e65000 b3e67000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e77000 b3e79000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e8a000 b3e8f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ea6000 b3ea8000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eb8000 b3ebf000 r-xp /usr/lib/libsensord-share.so
b3ecf000 b3ee7000 r-xp /usr/lib/libsensor.so.1.1.0
b3ef8000 b3efb000 r-xp /usr/lib/libXv.so.1.0.0
b3f0b000 b3f10000 r-xp /usr/lib/libutilX.so.1.1.0
b3f20000 b3f25000 r-xp /usr/lib/libappcore-common.so.1.1
b3f35000 b3f3c000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f4f000 b3f53000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f64000 b4042000 r-xp /usr/lib/libCOREGL.so.4.0
b4062000 b4065000 r-xp /usr/lib/libuuid.so.1.3.0
b4075000 b408c000 r-xp /usr/lib/libblkid.so.1.1.0
b409d000 b409f000 r-xp /usr/lib/libXau.so.6.0.0
b40af000 b40f6000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4108000 b410e000 r-xp /usr/lib/libjson-c.so.2.0.1
b411f000 b4123000 r-xp /usr/lib/libogg.so.0.7.1
b4133000 b4155000 r-xp /usr/lib/libvorbis.so.0.4.3
b4165000 b4249000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4265000 b4268000 r-xp /usr/lib/libEGL.so.1.4
b4279000 b427f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b428f000 b4291000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42a1000 b42ae000 r-xp /usr/lib/libGLESv2.so.2.0
b42bf000 b4321000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4336000 b434e000 r-xp /usr/lib/libmount.so.1.1.0
b4360000 b4374000 r-xp /usr/lib/libxcb.so.1.1.0
b4384000 b438b000 r-xp /lib/libcrypt-2.20-2014.11.so
b43c3000 b43c5000 r-xp /usr/lib/libiri.so
b43d5000 b43e0000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43f1000 b4427000 r-xp /usr/lib/libpulse.so.0.16.2
b4438000 b447b000 r-xp /usr/lib/libsndfile.so.1.0.25
b4490000 b44a5000 r-xp /lib/libexpat.so.1.5.2
b44b7000 b4575000 r-xp /usr/lib/libcairo.so.2.11200.14
b4589000 b4591000 r-xp /usr/lib/libdrm.so.2.4.0
b45a1000 b45a4000 r-xp /usr/lib/libdri2.so.0.0.0
b45b4000 b4602000 r-xp /usr/lib/libssl.so.1.0.0
b4617000 b4623000 r-xp /usr/lib/libeeze.so.1.13.0
b4634000 b463d000 r-xp /usr/lib/libethumb.so.1.13.0
b464d000 b4650000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4660000 b4817000 r-xp /usr/lib/libcrypto.so.1.0.0
b5602000 b560b000 r-xp /usr/lib/libXi.so.6.1.0
b561b000 b561d000 r-xp /usr/lib/libXgesture.so.7.0.0
b562d000 b5631000 r-xp /usr/lib/libXtst.so.6.1.0
b5641000 b5647000 r-xp /usr/lib/libXrender.so.1.3.0
b5657000 b565d000 r-xp /usr/lib/libXrandr.so.2.2.0
b566d000 b566f000 r-xp /usr/lib/libXinerama.so.1.0.0
b5680000 b5683000 r-xp /usr/lib/libXfixes.so.3.1.0
b5693000 b569e000 r-xp /usr/lib/libXext.so.6.4.0
b56ae000 b56b0000 r-xp /usr/lib/libXdamage.so.1.1.0
b56c0000 b56c2000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56d2000 b57b4000 r-xp /usr/lib/libX11.so.6.3.0
b57c8000 b57cf000 r-xp /usr/lib/libXcursor.so.1.0.2
b57df000 b57f7000 r-xp /usr/lib/libudev.so.1.6.0
b57f9000 b57fc000 r-xp /lib/libattr.so.1.1.0
b580c000 b582c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b582d000 b5832000 r-xp /usr/lib/libffi.so.6.0.2
b5843000 b585b000 r-xp /lib/libz.so.1.2.8
b586b000 b586d000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b587d000 b5952000 r-xp /usr/lib/libxml2.so.2.9.2
b5967000 b5a02000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a1e000 b5a21000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a31000 b5a4a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a5b000 b5a6c000 r-xp /lib/libresolv-2.20-2014.11.so
b5a80000 b5afa000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b0f000 b5b11000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b21000 b5b28000 r-xp /usr/lib/libembryo.so.1.13.0
b5b38000 b5b42000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b53000 b5b6b000 r-xp /usr/lib/libpng12.so.0.50.0
b5b7c000 b5b9f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bc0000 b5bd4000 r-xp /usr/lib/libector.so.1.13.0
b5be5000 b5bfd000 r-xp /usr/lib/liblua-5.1.so
b5c0e000 b5c65000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c79000 b5ca1000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cb2000 b5cc5000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cd6000 b5d10000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d21000 b5d2f000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d3f000 b5d47000 r-xp /usr/lib/libtbm.so.1.0.0
b5d57000 b5d64000 r-xp /usr/lib/libeio.so.1.13.0
b5d74000 b5d76000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d86000 b5d8b000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d9b000 b5db2000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc4000 b5de4000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df4000 b5e14000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e16000 b5e1c000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e2c000 b5e3d000 r-xp /usr/lib/libemotion.so.1.13.0
b5e4e000 b5e55000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e65000 b5e74000 r-xp /usr/lib/libeo.so.1.13.0
b5e85000 b5e97000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ea8000 b5ead000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ebd000 b5ed6000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ee6000 b5f03000 r-xp /usr/lib/libeet.so.1.13.0
b5f1c000 b5f64000 r-xp /usr/lib/libeina.so.1.13.0
b5f75000 b5f85000 r-xp /usr/lib/libefl.so.1.13.0
b5f96000 b607b000 r-xp /usr/lib/libicuuc.so.51.1
b6098000 b61d8000 r-xp /usr/lib/libicui18n.so.51.1
b61ef000 b6227000 r-xp /usr/lib/libecore_x.so.1.13.0
b6239000 b623c000 r-xp /lib/libcap.so.2.21
b624c000 b6275000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6286000 b628d000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b629f000 b62d6000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62e7000 b63d2000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63e5000 b645e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6470000 b6475000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6485000 b648f000 r-xp /usr/lib/libvconf.so.0.2.45
b649f000 b64a1000 r-xp /usr/lib/libvasum.so.0.3.1
b64b1000 b64b3000 r-xp /usr/lib/libttrace.so.1.1
b64c3000 b64c6000 r-xp /usr/lib/libiniparser.so.0
b64d6000 b64fc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b650c000 b6511000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6522000 b6539000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b654a000 b65b5000 r-xp /lib/libm-2.20-2014.11.so
b65c6000 b65cc000 r-xp /lib/librt-2.20-2014.11.so
b65dd000 b65ea000 r-xp /usr/lib/libunwind.so.8.0.1
b6620000 b6744000 r-xp /lib/libc-2.20-2014.11.so
b6759000 b6772000 r-xp /lib/libgcc_s-4.9.so.1
b6782000 b6864000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6875000 b689f000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68b0000 b68ec000 r-xp /usr/lib/libsystemd.so.0.4.0
b68ee000 b6971000 r-xp /usr/lib/libedje.so.1.13.0
b6984000 b69a2000 r-xp /usr/lib/libecore.so.1.13.0
b69c2000 b6b49000 r-xp /usr/lib/libevas.so.1.13.0
b6b7e000 b6b92000 r-xp /lib/libpthread-2.20-2014.11.so
b6ba6000 b6dda000 r-xp /usr/lib/libelementary.so.1.13.0
b6e09000 b6e0d000 r-xp /usr/lib/libsmack.so.1.0.0
b6e1d000 b6e24000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e34000 b6e36000 r-xp /usr/lib/libdlog.so.0.0.0
b6e46000 b6e49000 r-xp /usr/lib/libbundle.so.0.1.22
b6e59000 b6e5b000 r-xp /lib/libdl-2.20-2014.11.so
b6e6c000 b6e84000 r-xp /usr/lib/libaul.so.0.1.0
b6e98000 b6e9d000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eae000 b6ebb000 r-xp /usr/lib/liblptcp.so
b6ecd000 b6ed1000 r-xp /usr/lib/libsys-assert.so
b6ee2000 b6f02000 r-xp /lib/ld-2.20-2014.11.so
b6f13000 b6f18000 r-xp /usr/bin/launchpad-loader
b8b7f000 b8f28000 rw-p [heap]
befb2000 befd3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26809)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb664bb84) [/lib/libc.so.6] + 0x2bb84
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
0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-13 18:13:48.326+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 26392.
04-13 18:13:48.326+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1873
04-13 18:13:49.107+0900 I/UXT     (26723): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-13 18:13:52.661+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-13 18:13:56.064+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:13:56.584+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81285031
04-13 18:13:56.584+0900 I/MY_LOG  (26392): Button pressed
04-13 18:13:56.684+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81285130
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: vconf_get_bool(2729) > vconf_get_bool(26392) : db/ise/keysound error
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-13 18:13:56.684+0900 E/VCONF   (26392): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-13 18:13:56.765+0900 I/MY_LOG  (26392): Button unpressed
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-13 18:14:00.158+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 6:14
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오후 6:14"
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 6:14"
04-13 18:14:00.158+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-13 18:14:00.158+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146480136 Time: <font_size=31> </font_size> <font_size=31> 오후 6:14</font_size></font>"
04-13 18:14:16.063+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:14:17.515+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81305964
04-13 18:14:17.515+0900 I/MY_LOG  (26392): Button pressed
04-13 18:14:17.595+0900 E/EFL     (26392): ecore_x<26392> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81306042
04-13 18:14:17.605+0900 I/MY_LOG  (26392): Button unpressed
04-13 18:14:17.655+0900 D/basicui (26392): successed to load edc file
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:23.280+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.405+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-13 18:14:28.616+0900 E/RESOURCED(  684): proc-monitor.c: proc_dbus_watchdog_handler(711) > Receive watchdog signal to pid: 26392(client)
04-13 18:14:28.616+0900 E/RESOURCED(  684): proc-monitor.c: proc_dbus_watchdog_handler(727) > just kill watchdog process when debug enabled pid: 26392(client)
04-13 18:14:28.616+0900 E/RESOURCED(  684): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-13 18:14:28.616+0900 E/RESOURCED(  684): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-13 18:14:28.616+0900 E/RESOURCED(  684): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-13 18:14:28.786+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 26392 pgid = 26392
04-13 18:14:28.786+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(26392)
04-13 18:14:28.786+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:14:28.816+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-13 18:14:28.816+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-13 18:14:28.816+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-13 18:14:28.816+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-13 18:14:28.816+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-13 18:14:28.846+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-13 18:14:28.846+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-13 18:14:28.846+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-13 18:14:28.856+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[26392] terminate event is forwarded
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 26392, ]
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-13 18:14:28.856+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-13 18:14:28.856+0900 I/Tizen::App( 1246): (512) > Not registered pid(26392)
04-13 18:14:28.856+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-13 18:14:28.856+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:14:28.856+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 26392
04-13 18:14:28.856+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 26392
04-13 18:14:28.856+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 26392
04-13 18:14:28.856+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1877
04-13 18:14:28.866+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-13 18:14:28.876+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:14:28.876+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-13 18:14:28.876+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:14:28.876+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-13 18:14:28.876+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:14:28.876+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 26392.
04-13 18:14:28.916+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-13 18:14:28.916+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:14:28.926+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-13 18:14:28.926+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-13 18:14:28.926+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: fg
04-13 18:14:28.936+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:14:28.956+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:28.956+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:28.986+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-13 18:14:28.986+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-13 18:14:28.996+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-13 18:14:28.996+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-13 18:14:28.996+0900 W/CRASH_MANAGER(26736): worker.c: worker_job(1199) > 0626392636c691492074868
04-13 18:14:28.996+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-13 18:14:29.937+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:29.937+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:29.957+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:29.957+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:29.977+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:29.977+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:29.997+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:29.997+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.007+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.017+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.027+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.027+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.047+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.047+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.067+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.067+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.087+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.087+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.107+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.107+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.117+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.127+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:30.137+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:14:30.137+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:14:36.063+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:14:38.615+0900 E/RESOURCED(  684): procfs.c: proc_get_oom_score_adj(131) > fopen /proc/26392/oom_score_adj failed
04-13 18:14:56.082+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:15:00.176+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-13 18:15:00.176+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 6:15
04-13 18:15:00.176+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오후 6:15"
04-13 18:15:00.176+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 6:15"
04-13 18:15:00.176+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-13 18:15:00.176+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146428786 Time: <font_size=31> </font_size> <font_size=31> 오후 6:15</font_size></font>"
04-13 18:15:16.062+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:15:36.071+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:15:56.071+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:16:00.215+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-13 18:16:00.215+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 6:16
04-13 18:16:00.215+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오후 6:16"
04-13 18:16:00.215+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 6:16"
04-13 18:16:00.215+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-13 18:16:00.215+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146439534 Time: <font_size=31> </font_size> <font_size=31> 오후 6:16</font_size></font>"
04-13 18:16:16.060+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:16:22.196+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81430639
04-13 18:16:22.276+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81430727
04-13 18:16:22.296+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-13 18:16:22.296+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-13 18:16:22.296+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-13 18:16:22.307+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
04-13 18:16:22.307+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-13 18:16:22.307+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-13 18:16:22.307+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-13 18:16:22.307+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-13 18:16:22.327+0900 I/abc     (26723): abc
04-13 18:16:22.327+0900 I/CAPI_APPFW_APPLICATION(26723): app_main.c: ui_app_main(789) > app_efl_main
04-13 18:16:22.327+0900 I/CAPI_APPFW_APPLICATION(26723): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-13 18:16:22.347+0900 E/TBM     (26723): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-13 18:16:22.407+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 26723, appid: org.example.client
04-13 18:16:22.407+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-13 18:16:22.407+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(26723)
04-13 18:16:22.627+0900 I/APP_CORE(26723): appcore-efl.c: __do_app(514) > [APP 26723] Event: RESET State: CREATED
04-13 18:16:22.627+0900 I/CAPI_APPFW_APPLICATION(26723): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-13 18:16:22.637+0900 E/EFL     (26723): edje<26723> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:16:22.637+0900 E/EFL     (26723): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:16:22.647+0900 E/EFL     (26723): edje<26723> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:16:22.647+0900 E/EFL     (26723): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:16:22.657+0900 E/EFL     (26723): edje<26723> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:16:22.657+0900 E/EFL     (26723): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:16:22.657+0900 W/APP_CORE(26723): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-13 18:16:22.667+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-13 18:16:22.667+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:16:22.667+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:16:22.687+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-13 18:16:22.687+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:16:22.687+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:16:22.697+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-13 18:16:22.757+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-13 18:16:22.757+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-13 18:16:22.757+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-13 18:16:22.767+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-13 18:16:22.767+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-13 18:16:22.767+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-13 18:16:22.767+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(26723) status(3)
04-13 18:16:22.777+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(26723)
04-13 18:16:22.777+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 26723, appid: org.example.client, status: fg
04-13 18:16:22.777+0900 I/APP_CORE(26723): appcore-efl.c: __do_app(514) > [APP 26723] Event: RESUME State: CREATED
04-13 18:16:22.777+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-13 18:16:22.777+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-13 18:16:22.777+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: bg
04-13 18:16:22.787+0900 I/APP_CORE(26723): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-13 18:16:22.787+0900 I/APP_CORE(26723): appcore-efl.c: __do_app(625) > [APP 26723] Initial Launching, call the resume_cb
04-13 18:16:22.787+0900 I/CAPI_APPFW_APPLICATION(26723): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:16:22.937+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:16:23.137+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(26723) status(0)
04-13 18:16:23.458+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-13 18:16:23.458+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 26723.
04-13 18:16:23.458+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1879
04-13 18:16:23.728+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81432173
04-13 18:16:23.818+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81432261
04-13 18:16:24.268+0900 I/UXT     (26809): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-13 18:16:24.429+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81432869
04-13 18:16:24.429+0900 I/MY_LOG  (26723): Button pressed
04-13 18:16:24.509+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81432957
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf.c: vconf_get_bool(2729) > vconf_get_bool(26723) : db/ise/keysound error
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-13 18:16:24.509+0900 E/VCONF   (26723): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-13 18:16:24.559+0900 I/MY_LOG  (26723): Button unpressed
04-13 18:16:25.299+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81433746
04-13 18:16:25.299+0900 I/MY_LOG  (26723): Button pressed
04-13 18:16:25.359+0900 E/EFL     (26723): ecore_x<26723> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81433812
04-13 18:16:25.369+0900 I/MY_LOG  (26723): Button unpressed
04-13 18:16:25.410+0900 D/basicui (26723): successed to load edc file
04-13 18:16:25.570+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:16:25.580+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 26723 pgid = 26723
04-13 18:16:25.580+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(26723)
04-13 18:16:25.590+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-13 18:16:25.590+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-13 18:16:25.590+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-13 18:16:25.590+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-13 18:16:25.590+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-13 18:16:25.630+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-13 18:16:25.630+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-13 18:16:25.630+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-13 18:16:25.630+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-13 18:16:25.630+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 26723
04-13 18:16:25.630+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[26723] terminate event is forwarded
04-13 18:16:25.630+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-13 18:16:25.630+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 26723, ]
04-13 18:16:25.630+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-13 18:16:25.630+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-13 18:16:25.630+0900 I/Tizen::App( 1246): (512) > Not registered pid(26723)
04-13 18:16:25.630+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-13 18:16:25.630+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:16:25.630+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 26723
04-13 18:16:25.630+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 26723
04-13 18:16:25.650+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:16:25.650+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 26723.
04-13 18:16:25.670+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-13 18:16:25.670+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:16:25.670+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-13 18:16:25.670+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:16:25.690+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-13 18:16:25.690+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-13 18:16:25.690+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: fg
04-13 18:16:25.700+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:25.700+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:25.700+0900 W/CRASH_MANAGER(26815): worker.c: worker_job(1199) > 0626723636c691492074985
04-13 18:16:25.720+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-13 18:16:25.720+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:16:25.740+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:16:25.750+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-13 18:16:25.750+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-13 18:16:25.760+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-13 18:16:25.760+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-13 18:16:25.760+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-13 18:16:26.711+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.721+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.731+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.741+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.751+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.751+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.771+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.771+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.791+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.791+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.811+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.811+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.821+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.831+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.841+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.841+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.861+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.861+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.881+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.881+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.901+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.901+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:26.911+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:16:26.921+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:16:36.060+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:16:56.069+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:17:00.234+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-13 18:17:00.234+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 6:17
04-13 18:17:00.234+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오후 6:17"
04-13 18:17:00.234+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 6:17"
04-13 18:17:00.234+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-13 18:17:00.234+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146375999 Time: <font_size=31> </font_size> <font_size=31> 오후 6:17</font_size></font>"
04-13 18:17:16.079+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:17:24.177+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81492621
04-13 18:17:24.247+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81492698
04-13 18:17:24.257+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-13 18:17:24.267+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-13 18:17:24.267+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-13 18:17:24.277+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
04-13 18:17:24.277+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-13 18:17:24.277+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-13 18:17:24.277+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-13 18:17:24.277+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-13 18:17:24.297+0900 I/abc     (26809): abc
04-13 18:17:24.297+0900 I/CAPI_APPFW_APPLICATION(26809): app_main.c: ui_app_main(789) > app_efl_main
04-13 18:17:24.297+0900 I/CAPI_APPFW_APPLICATION(26809): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-13 18:17:24.317+0900 E/TBM     (26809): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-13 18:17:24.377+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 26809, appid: org.example.client
04-13 18:17:24.377+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-13 18:17:24.377+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(26809)
04-13 18:17:24.597+0900 I/APP_CORE(26809): appcore-efl.c: __do_app(514) > [APP 26809] Event: RESET State: CREATED
04-13 18:17:24.597+0900 I/CAPI_APPFW_APPLICATION(26809): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-13 18:17:24.607+0900 E/EFL     (26809): edje<26809> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:17:24.607+0900 E/EFL     (26809): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:17:24.617+0900 E/EFL     (26809): edje<26809> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:17:24.617+0900 E/EFL     (26809): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:17:24.617+0900 E/EFL     (26809): edje<26809> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-13 18:17:24.617+0900 E/EFL     (26809): By the power of Grayskull, your previous Embryo stack is now broken!
04-13 18:17:24.627+0900 W/APP_CORE(26809): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-13 18:17:24.627+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-13 18:17:24.627+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:17:24.627+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:17:24.657+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-13 18:17:24.657+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:17:24.657+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:17:24.657+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-13 18:17:24.727+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-13 18:17:24.727+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-13 18:17:24.727+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-13 18:17:24.737+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-13 18:17:24.737+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-13 18:17:24.737+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-13 18:17:24.737+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(26809) status(3)
04-13 18:17:24.737+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(26809)
04-13 18:17:24.737+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 26809, appid: org.example.client, status: fg
04-13 18:17:24.737+0900 I/APP_CORE(26809): appcore-efl.c: __do_app(514) > [APP 26809] Event: RESUME State: CREATED
04-13 18:17:24.747+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-13 18:17:24.747+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-13 18:17:24.747+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: bg
04-13 18:17:24.757+0900 I/APP_CORE(26809): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-13 18:17:24.757+0900 I/APP_CORE(26809): appcore-efl.c: __do_app(625) > [APP 26809] Initial Launching, call the resume_cb
04-13 18:17:24.757+0900 I/CAPI_APPFW_APPLICATION(26809): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:17:24.948+0900 E/RESOURCED(  684): datausage-common.c: finalize_counter(1397) > There is no iptables_rule handler
04-13 18:17:25.108+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(26809) status(0)
04-13 18:17:25.428+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-13 18:17:25.428+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 26809.
04-13 18:17:25.448+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1885
04-13 18:17:25.598+0900 E/EFL     (26809): ecore_x<26809> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81494027
04-13 18:17:25.668+0900 E/EFL     (26809): ecore_x<26809> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81494116
04-13 18:17:26.219+0900 I/UXT     (26881): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-13 18:17:26.319+0900 E/EFL     (26809): ecore_x<26809> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81494770
04-13 18:17:26.319+0900 I/MY_LOG  (26809): Button pressed
04-13 18:17:26.379+0900 E/EFL     (26809): ecore_x<26809> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81494836
04-13 18:17:26.389+0900 E/VCONF   (26809): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-13 18:17:26.389+0900 E/VCONF   (26809): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-13 18:17:26.389+0900 E/VCONF   (26809): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-13 18:17:26.389+0900 E/VCONF   (26809): vconf.c: vconf_get_bool(2729) > vconf_get_bool(26809) : db/ise/keysound error
04-13 18:17:26.389+0900 E/VCONF   (26809): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-13 18:17:26.389+0900 E/VCONF   (26809): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-13 18:17:26.429+0900 I/MY_LOG  (26809): Button unpressed
04-13 18:17:27.080+0900 E/EFL     (26809): ecore_x<26809> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=81495531
04-13 18:17:27.080+0900 I/MY_LOG  (26809): Button pressed
04-13 18:17:27.160+0900 E/EFL     (26809): ecore_x<26809> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=81495608
04-13 18:17:27.170+0900 I/MY_LOG  (26809): Button unpressed
04-13 18:17:27.200+0900 D/basicui (26809): successed to load edc file
04-13 18:17:27.350+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:17:27.360+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 26809 pgid = 26809
04-13 18:17:27.360+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(26809)
04-13 18:17:27.370+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-13 18:17:27.370+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-13 18:17:27.370+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-13 18:17:27.370+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-13 18:17:27.370+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-13 18:17:27.420+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-13 18:17:27.440+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-13 18:17:27.440+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-13 18:17:27.440+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-13 18:17:27.450+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-13 18:17:27.460+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-13 18:17:27.460+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-13 18:17:27.460+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-13 18:17:27.470+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 26809
04-13 18:17:27.470+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 26809
04-13 18:17:27.470+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 26809
04-13 18:17:27.480+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1889
04-13 18:17:27.480+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-13 18:17:27.480+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-13 18:17:27.490+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-13 18:17:27.490+0900 I/CAPI_WIDGET_APPLICATION( 1437): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-13 18:17:27.490+0900 W/AUL     ( 1437): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1437, appid: live-com.samsung.browser, status: fg
04-13 18:17:27.510+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-13 18:17:27.510+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-13 18:17:27.520+0900 E/cluster-home(  868): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-13 18:17:27.520+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-13 18:17:27.520+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-13 18:17:27.520+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-13 18:17:27.520+0900 W/cluster-view(  868): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-13 18:17:27.580+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-13 18:17:27.590+0900 W/CRASH_MANAGER(26886): worker.c: worker_job(1199) > 0626809636c69149207504
